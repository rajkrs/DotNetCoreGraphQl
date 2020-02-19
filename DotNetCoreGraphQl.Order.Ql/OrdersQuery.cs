using DotNetCoreGraphQl.Order.Providers;
using DotNetCoreGraphQl.Order.Ql.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.Ql
{
    public class OrdersQuery : ObjectGraphType<object>
    {
        public OrdersQuery(IOrderProvider orderProvider)
        {
            Name = "Query";

            Field<OrderDetailsType>(
                "orderDetails",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "orderId", Description="Order ID" }
                ),
                resolve: context =>
                {
                    return orderProvider.GetOrderDetails(context.GetArgument<Int64>("orderId"));
                });
        }

    }
}
