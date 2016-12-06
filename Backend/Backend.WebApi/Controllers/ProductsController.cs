using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    public class ProductsController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product() { Id = 01, Name = "Bum", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 02, Name = "Bim", Category ="Varmluft", Price = 200.00m },
            new Product() { Id = 03, Name = "Busse", Category ="Kram", Price = 500.750m },
            new Product() { Id = 06, Name = "Bam", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 04, Name = "Tusse", Category ="Kys", Price = 1500.00m },
            new Product() { Id = 05, Name = "Nusse", Category ="KysKram", Price = 10.50m },
            new Product() { Id = 11, Name = "BumBlue", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 12, Name = "BumRead", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 13, Name = "BumYellow", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 14, Name = "BumGreen", Category ="Varmluft", Price = 100.00m },
            new Product() { Id = 15, Name = "BumPink", Category ="Varmluft", Price = 100.00m }
        };
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int Id)
        {
            var product = this.products.Where(p => p.Id == Id)
                .SingleOrDefault();

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(product);
            }
        }
    }
}
