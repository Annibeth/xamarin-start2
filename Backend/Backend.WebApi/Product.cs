using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend.WebApi
{


    public class Product : TableEntity 
    {
        //internal object reviews;

        //public int Id { get; set; }

        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
         
    }
    
}