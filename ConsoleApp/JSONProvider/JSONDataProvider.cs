using System;
using System.IO;
using System.Runtime.Serialization.Json;
using DataProviderContract;
using System.Collections.Generic;

namespace JSONProvider
{
    public class JSONDataProvider<T> : IDataProvider<T>
    {
        public List<T> Read(string connection)
        {
            List<T> data;

            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<T>));

                try
                {
                    data = (List<T>)formatter.ReadObject(fs);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            return data;
        }

        public void Write(T data, string connection)
        {
            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {

                DataContractJsonSerializer formatter = new DataContractJsonSerializer(typeof(List<T>));

                List<T> currentData = new List<T>();
                if (fs.Length != 0)
                {
                    currentData = (List<T>)formatter.ReadObject(fs);
                    fs.SetLength(0);
                }    
                currentData.Add(data);

                try
                {
                    formatter.WriteObject(fs, currentData);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        public void ClearFile(string connection)
        {
            using (FileStream fs = File.Open(connection, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                fs.SetLength(0);
            }
        }
    }
}
