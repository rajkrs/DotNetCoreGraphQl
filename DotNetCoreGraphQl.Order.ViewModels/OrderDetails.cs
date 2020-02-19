using System;

namespace DotNetCoreGraphQl.Order.ViewModels
{
    public class OrderDetails
    {
        public Int64 OrderId { get; set; }

        public Product Product { get; set; }

        public decimal TotalPrice { get; set; }
    }
}
