using DataProviderContract;
using System.Collections.Generic;

namespace DAL
{
    public interface IDataContext<T>
    {
        string Connection { get; }
        IDataProvider<T> DataProvider { get; set; }

        List<T> GetData();
        void SetData(T data);
        void ClearData();
    }
}
