﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductApiWithVersions.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Ean { get; set; }
        public double Price { get; set; }

    }
}
