﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEAV_0.Models.Entities
{
    public class EntityAttribute:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<ProductAttribute> ProductAttributes { get; set; }
    }
}
