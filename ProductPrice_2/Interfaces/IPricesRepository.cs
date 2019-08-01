using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProductPrice_2.Models;

namespace ProductPrice_2.Interfaces
{
    public  interface IPricesRepository
    {
        Task<IEnumerable<Price>> GetAllPricessAsync();
        Task<Price> GetPricebyIdAsync(int priceId);
    }
}
