﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TwitterBootStrapPlayground.Models
{
    public class Braclet
    {
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }
        public int UnitsInStock { get; set; }
        public bool Discontinued { get; set; }

    }
}