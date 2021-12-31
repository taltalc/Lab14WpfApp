using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public enum ProductTypes
    {
        Food,
        Appliance   
    }
    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string Kartinka { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
