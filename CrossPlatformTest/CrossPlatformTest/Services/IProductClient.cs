using CrossPlatformTest.Models;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrossPlatformTest.Services
{
    public interface IProductClient
    {
        [Get("/api/Product")]
        Task<List<Product>> GetAsync();
    }
}
