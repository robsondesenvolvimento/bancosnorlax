namespace BancoSnorlax.Domain.Contracts
{
    public interface IWriteBankSnorlax<T>
    {
        T Add(T obj);
        void Remove(int id);
    }
}
