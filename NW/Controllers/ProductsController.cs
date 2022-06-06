using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NW.Data;
using NW.Models;
using NW.Services;

namespace NW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly NorthwindContext _context;
        public ProductService _productService;

        public ProductsController(NorthwindContext context, ProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        // GET: api/Products
        [HttpGet]
        public IActionResult GetProducts()
        {
         
          var tenExpensiveProducts= _productService.GetTenExpensiveProductsAsync();
            return Ok(tenExpensiveProducts);

        }

    }
}
