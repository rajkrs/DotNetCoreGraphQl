using ComplexFaker;
using DotNetCoreGraphQl.Order.ViewModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCoreGraphQl.Order.Ql.Types
{
    public class ProductType : ObjectGraphType<Product>
    {

        public ProductType(IFakeDataService fakeDataService)
        {
            Name = "Product";
            Field(x => x.Name);
            Field(x => x.ProductId);
            Field(x => x.TotalPrice);

            Field<PriceType>(
                "price",
                resolve: context =>
                {
                    var productId = context.Source.ProductId;
                    //get price based on productId from db or any storage. here i am generating fake data;
                    return fakeDataService.GenerateComplex<Price>();
                });
        }
    }
}
