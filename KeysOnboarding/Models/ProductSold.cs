using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KeysOnboarding.Models
{
    public class ProductSold
    {
        public virtual int Id { get; set; }
        public virtual int ProductId { get; set; }
        public virtual int CustomerId { get; set; }
        public virtual int StoreId { get; set; }
        public virtual  DateTime DateSold { get; set; }

    }
}