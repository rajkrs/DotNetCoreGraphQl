using DotNetCoreGraphQl.Order.ViewModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.Ql.Types
{
    public class CartInputType : InputObjectGraphType<Cart>
    {
        public CartInputType()
        {
            Name = "cartInput";
            Field(x => x.Quantity, nullable: false);
            Field(x => x.ProductId, nullable: false);
            Field<StringGraphType>("remarks", "Optional remarks.");
             
        }
    }
}
