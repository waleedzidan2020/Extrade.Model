﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class Cart
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int ProductID { get; set; }
        public float Quantity { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }

    }
}
