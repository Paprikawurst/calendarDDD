using System.Collections.Generic;
using System.Threading.Tasks;
using ProductsDDD.Domain.Models;
using ProductsDDD.Domain.Shared.Enums;
using ProductsDDD.Models;

namespace ProductsDDD.Application.Contracts
{
    public interface IProductService
    {
        Task<ProductModel> Add(ProductModel model);
        Task<List<ProductModel>> GetAllProducts();
    }
}