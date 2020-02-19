using DotNetCoreGraphQl.Order.ViewModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.Ql.Types
{
    public class PriceType : ObjectGraphType<Price>
    {

        public PriceType()
        {
            Name = "Price";
            Field(x => x.DiscountAmount);
            Field(x => x.GSTAmount);
            Field(x => x.RawAmount);
            Field(x => x.ShippingAmount);
        }
    }
}
