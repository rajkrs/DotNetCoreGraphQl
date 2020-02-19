using ComplexFaker;
using DotNetCoreGraphQl.Order.ViewModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.Ql.Types
{
    public class OrderDetailsType : ObjectGraphType<OrderDetails>
    {

        public OrderDetailsType(IFakeDataService fakeDataService)
        {
            Name = "OrderDetails";

            Field (x => x.OrderId);
            Field(x => x.TotalPrice);

            Field<ProductType>(
                "product",
                resolve: context =>
                {
                    //var orderid = context.GetArgument<Int64>("orderId");
                    //get product based on orderid from db or any storage. here i am generating fake data;
                    return fakeDataService.GenerateComplex<Product>();
                });

        }
    }
}
