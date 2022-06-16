using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extrade.models
{
    public class PhoneDriver
    {
     public int ID { get; set; }
        public int Number { get; set; }
        public int Driverid { get; set; }

        public Driver Driver { get; set; }



    }
}
