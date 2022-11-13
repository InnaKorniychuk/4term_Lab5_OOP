using BinaryProvider;
using JSONProvider;
using DataProviderContract;
using System;

namespace BLL
{
    public class ConfigurationService
    {
        string connection = @"..\DataBase\";
        public ReadWriteDataProvider dataProvider { get; set; }

        public void SetConfiguraion(int dataProviderType)
        {
            dataProvider = ReadWriteDataProvider.GetInstance
                (new ReadWriteService<Student>
                    (connection + "students" + SetConnection(dataProviderType), SetDataProvider<Student>(dataProviderType)),
                new ReadWriteService<Librarian>
                    (connection + "librarians" + SetConnection(dataProviderType), SetDataProvider<Librarian>(dataProviderType)),
                new ReadWriteService<SoftwareDeveloper>
                    (connection + "developers" + SetConnection(dataProviderType), SetDataProvider<SoftwareDeveloper>(dataProviderType)));
        }

        public IDataProvider<T> SetDataProvider<T>(int dataProviderType)
        {
            if (dataProviderType < 1 || dataProviderType > 2)
                throw new IndexOutOfRangeException("data provider type must be in range 1 to 2");
            IDataProvider<T>[] providers = { new BinaryDataProvider<T>(), new JSONDataProvider<T>() };
            return providers[dataProviderType - 1];
        }

        public string SetConnection(int dataProviderType)
        {
            if (dataProviderType < 1 || dataProviderType > 2)
                throw new IndexOutOfRangeException("Data provider type must be in range 1 to 2");
            string[] providers = { ".bin", ".json" };
            return providers[dataProviderType - 1];
        }
    }

}
