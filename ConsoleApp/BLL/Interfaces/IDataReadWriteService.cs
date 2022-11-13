using System.Collections.Generic;

namespace BLL
{
    public interface IDataReadWriteService<T>
    {
        List<T> ReadData();
        void WriteData(T data);
        void ClearData();
    }
}