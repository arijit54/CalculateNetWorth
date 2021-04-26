using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculateNetWorth.Models
{
    public interface ICalculateNetWorth
    {

        Task<List<StockTransactionDetails>> GetStockTransactionDetails(Customer customer);
        Task<List<MutualFundTransactionDetails>> GetMutualFundTransactionDetails(Customer customer);

        void SellStock(int id);
        void SellMutualFund(int id);

        
    }
}
