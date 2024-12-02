﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MachinTest.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }

        // Navigation property
        public virtual Category Category { get; set; }
        public string CategoryName { get; internal set; }
    }
}