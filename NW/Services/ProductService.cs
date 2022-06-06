using Microsoft.EntityFrameworkCore;
using NW.Data;
using NW.Models;

namespace NW.Services
{
    public class ProductService
    {
        private NorthwindContext _context;
        public ProductService(NorthwindContext context)
        {
            _context=context;
        }

        public List<Product> GetTenExpensiveProductsAsync()
        {
           return  _context.Products.OrderByDescending(a => a.UnitPrice).Take(10).ToList();
        }
    }
}
