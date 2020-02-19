using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.ViewModels
{
    public class Price
    {
        public decimal RawAmount { get; set; } = 0;
        public decimal GSTAmount { get; set; } = 0;
        public decimal DiscountAmount { get; set; } = 0;
        public decimal ShippingAmount { get; set; } = 0;
    }
}
