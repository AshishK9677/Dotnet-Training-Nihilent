namespace Services;
using Entities;

public interface ITransactionServices
{
   Person updateBalance(int id, decimal amount, string action);
}
