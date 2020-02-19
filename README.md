# DotNetCoreGraphQl


```javascript
query{
  orderDetails(orderId:12){
    orderId,
    product{
      name
    },
    totalPrice
  }
}
```


```javascript
mutation {
  addToCart(cart: {
    quantity : 1,
    productId: 212,
    remarks : "Its too good"
  }) {
    orderId,
    product{
      name
    },
    totalPrice
  }
}
```

