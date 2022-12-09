namespace dotnetwithmongo.Data.Interfaces
{
    public interface IDelete<T>
    {
        bool Delete(T id);
    }
}
