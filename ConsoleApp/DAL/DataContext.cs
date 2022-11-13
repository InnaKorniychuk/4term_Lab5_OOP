using System;
using DataProviderContract;
using System.Collections.Generic;

namespace DAL
{
    public class DataContext<T> : IDataContext<T>
    {
        public string Connection { get; private set; }
        public IDataProvider<T> DataProvider { get; set; }

        public DataContext(string connection, IDataProvider<T> dataProvider)
        {
            Connection = connection;
            DataProvider = dataProvider;
        }

        public List<T> GetData()
        {
            List<T> data;

            if (DataProvider != null)
            {
                try
                {
                    data = DataProvider.Read(Connection);
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            return data;
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }

        public void SetData(T data)
        {
            if (DataProvider != null)
            {
                DataProvider.Write(data, Connection);
            }
            else
                throw new InvalidOperationException("Data provider is undefined");
        }

        public void ClearData()
        {
            DataProvider.ClearFile(Connection);
        }
    }

}

