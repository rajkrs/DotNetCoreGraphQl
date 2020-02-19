using System;
using DotNetCoreGraphQl.Order.ViewModels;

namespace DotNetCoreGraphQl.Order.Providers
{
    public interface IOrderProvider
    {
        OrderDetails CreateOrder(Cart cart);
        OrderDetails GetOrderDetails(Int64 orderId);
    }
}
