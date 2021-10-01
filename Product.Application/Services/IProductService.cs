using ProductNS.Application.Dtos;
using ProductNS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductNS.Application.Services
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts(string sortParameter);
        Task<IEnumerable<Product>> GetProductsAdmin();
        Task<ProductDto> GetProduct(int id);
        Task<int> CreateProduct(CreateProductDto dto);
        Task<bool> DeleteProduct(int id);
        Task UpdateProduct(int id, UpdateProductDto dto);
    }
}
