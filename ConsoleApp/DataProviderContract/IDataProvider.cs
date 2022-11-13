using System.Collections.Generic;

namespace DataProviderContract
{
    public interface IDataProvider<T>
    {
        List<T> Read(string connection);
        void Write(T data, string connection);
        void ClearFile(string connection);
    }
}