﻿using System;
using System.Collections.Generic;

namespace SalesManagement.Shared.ValueObject
{
    public partial class ProductVO
    {
        public int PurchaseAmount { get; set; }
        public bool Picked { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string ProductNumber { get; set; }
        public string Color { get; set; }
        public decimal ListPrice { get; set; }
        public string Size { get; set; }
        public decimal? Weight { get; set; }
        public int? ProductCategoryId { get; set; }
        public int? ProductModelId { get; set; }
        
    }
}
