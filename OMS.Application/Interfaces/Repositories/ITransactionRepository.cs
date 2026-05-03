
using System.Transactions;

namespace OMS.Application.Interfaces.Repositories
{
    public interface ITransactionRepository
    {
        Task AddAsync(Transaction transaction);
    }
}
