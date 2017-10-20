using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeysOnboarding.Models
{
    public class Store
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string   Address { get; set; }
        public virtual List<ProductSold> ProductSolds { get; set; }
    }
}