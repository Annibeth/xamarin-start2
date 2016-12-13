using Backend.WebApi;
using Microsoft.Azure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Backend.WebApi.Controllers
{
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private Review[] review = new Review[]
        {
             new Review() { Id = 100, ProductId =01, Rating=1, Text="God" },
             new Review() { Id = 110, ProductId =01, Rating=1, Text="jeppe" },
             new Review() { Id = 101, ProductId =01, Rating=1, Text="sådan ca" },
             new Review() { Id = 102, ProductId =01, Rating=1, Text="ikkesåringe" },
             new Review() { Id = 140, ProductId =01, Rating=1, Text="ikketilatsige" },
             new Review() { Id = 160, ProductId =01, Rating=1, Text="blalba" },
             new Review() { Id = 170, ProductId =01, Rating=1, Text="hmhmhm" },
             new Review() { Id = 177, ProductId =01, Rating=1, Text="God" },
             new Review() { Id = 178, ProductId =02, Rating=5, Text="Bad" }
        };

        private Product[] products = new Product[]
        {
            new Product() {  PartitionKey="MitProdukt", RowKey = "01", Name = "Bum", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "02", Name = "Bim", Category ="Varmluft", Price = 200.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "03", Name = "Busse", Category ="Kram", Price = 500.750 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "06", Name = "Bam", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "04", Name = "Tusse", Category ="Kys", Price = 1500.00},
            new Product() {  PartitionKey="MitProdukt", RowKey = "05", Name = "Nusse", Category ="KysKram", Price = 10.50 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "11", Name = "BumBlue", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "12", Name = "BumRead", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "13", Name = "BumYellow", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "14", Name = "BumGreen", Category ="Varmluft", Price = 100.00 },
            new Product() {  PartitionKey="MitProdukt", RowKey = "15", Name = "BumPink", Category ="Varmluft", Price = 100.00 }
        };



        private CloudTableClient CreateTableClient()
        {
            CloudStorageAccount storageAccount =
                CloudStorageAccount.Parse(
                    ConfigurationManager.ConnectionStrings["StorrageConnectionString"].ConnectionString);

            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            return tableClient;




        }
        internal void InitializeSampelData()
        {
            var ctc = CreateTableClient();
            var producttabel = ctc.GetTableReference("products");
            producttabel.CreateIfNotExists();
            foreach (var item in products)
            {
                var myInstans = TableOperation.InsertOrReplace(item);
                producttabel.Execute(myInstans);
            }
        }

        [Route("")]
        [HttpGet]
        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        //[Route("{Id}")]
        //[HttpGet]
        //public IHttpActionResult GetProduct(int Id)
        //{
        //    var product = this.products.Where(p => p.Id == Id)
        //        .SingleOrDefault();

        //    if (product == null)
        //    {
        //        return NotFound();
        //    }
        //    else
        //    {
        //        return Ok(product);
        //    }
        //}



        [Route("{Id}")]
        [HttpGet]
        public Product GetProduct(string Id)
        {
            var product = this.products.Where(p => p.RowKey == Id)
                .SingleOrDefault();

            if (product == null)
            {
                throw new NotFoundException();
            }
            else
            {
                return product;
            }
        }




        [Route("{productId}/reviews")]
        [HttpGet]

        public IEnumerable<Review> GetReviewsForProduct(int productId)
        {
            return this.review.Where(p => p.ProductId == productId);

        }
    }
}
