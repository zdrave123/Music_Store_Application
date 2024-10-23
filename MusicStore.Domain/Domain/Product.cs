﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore.Domain.Domain
{
    public abstract class Product : BaseEntity
    {
        public string Name { get; set; }      
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public int Stock { get; set; }       
    }

}
