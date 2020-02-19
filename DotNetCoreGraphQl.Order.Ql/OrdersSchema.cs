using System;
using GraphQL.Types;
using GraphQL.Utilities;


namespace DotNetCoreGraphQl.Order.Ql
{
    public class OrdersSchema : Schema
    {
        public OrdersSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetService(typeof(OrdersQuery)) as OrdersQuery;
            Mutation = provider.GetService(typeof(OrdersMutation)) as OrdersMutation;
        }
    }
}
