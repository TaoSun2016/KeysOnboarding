﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeysOnboarding.Models
{
    public class Product
    {
        public virtual int Id { get; set; }
        public virtual int ProductSoldId { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual List<ProductSold> ProductSolds { get; set; }
    }
}