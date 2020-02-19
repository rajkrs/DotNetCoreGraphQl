using DotNetCoreGraphQl.Order.Providers;
using DotNetCoreGraphQl.Order.Ql.Types;
using DotNetCoreGraphQl.Order.ViewModels;
using GraphQL.Types;
using System;

namespace DotNetCoreGraphQl.Order.Ql
{
    public class OrdersMutation : ObjectGraphType
    {

        public OrdersMutation(IOrderProvider orderProvider )
        {
            Name = "Mutation";

            Field<OrderDetailsType>(
                "addToCart",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CartInputType>> { Name = "cart" }
                ),
                resolve: context =>
                {
                    //Resolve cart object from cartInputType
                    var cartInput = context.GetArgument<Cart>("cart");

                    //Resolve additional remarks from cartInputType
                    var remark = context.GetArgument<dynamic>("cart")["remarks"];

                    //Do whatever you want to do, and return data.
                    return orderProvider.CreateOrder(cartInput);
                });
        }
    }
}
