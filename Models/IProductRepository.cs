﻿using System.Collections.Generic;

namespace SportStore.Models
{
    interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int productID);
    }
}
