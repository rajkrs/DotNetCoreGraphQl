using ComplexFaker;
using DotNetCoreGraphQl.Order.ViewModels;
using System;

namespace DotNetCoreGraphQl.Order.Providers
{
    public class OrderProvider : IOrderProvider
    {

        public readonly IFakeDataService _fakeDataService;
        public OrderProvider(IFakeDataService fakeDataService)
        {
            _fakeDataService = fakeDataService;
        }

        public OrderDetails CreateOrder(Cart cart) =>
            _fakeDataService.GenerateComplex<OrderDetails>();


        public OrderDetails GetOrderDetails(Int64 orderId ) =>
            _fakeDataService.GenerateComplex<OrderDetails>();
    }
}