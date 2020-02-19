using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.ViewModels
{
    public class Product
    {
        public Int64 ProductId { get; set; }
        public string Name { get; set; }
        public Price PriceDetails { get; set; }
        public decimal TotalPrice { get; set; }


    }
}
