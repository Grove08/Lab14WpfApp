﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14WpfApp
{
    public enum ProductCategorys
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string? ProdName { get; set; }
        public decimal ProdPrice { get; set; }
        public string? ProdImage { get; set; }
        public ProductCategorys ProductCategory { get; set;}
    }
}
