using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using DataProviderContract;
using System.Collections.Generic;

namespace BinaryProvider
{
    public class BinaryDataProvider<T> : IDataProvider<T>
    {
        public List<T> Read(string connection)
        {
            List<T> data;

            using (FileStream fs = new FileStream(connection, FileMode.OpenOrCreate))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    data = (List<T>)formatter.Deserialize(fs);
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
                BinaryFormatter formatter = new BinaryFormatter();

                List<T> currentData = new List<T>();
                if (fs.Length != 0)
                {
                    currentData = (List<T>)formatter.Deserialize(fs);
                    fs.SetLength(0);
                }
                currentData.Add(data);

                try
                {
                    formatter.Serialize(fs, currentData);
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
