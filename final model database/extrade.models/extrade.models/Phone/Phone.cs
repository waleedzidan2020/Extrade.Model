﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace extrade.models
{
    public class Phone
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Number { get; set; }
        public User User { get; set; }


    }
}
