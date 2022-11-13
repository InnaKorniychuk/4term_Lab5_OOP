namespace BLL
{
    public interface IEntityService<T>
    {
        void Add(T data);
        void Remove(T item);
        T Search(T item);
        string Show();
    }
}
