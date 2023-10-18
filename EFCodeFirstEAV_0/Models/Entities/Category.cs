using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirstEAV_0.Models.Entities
{
    public class Category:BaseEntity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Relational Properties
        public virtual List<Product> Products { get; set; }
    }
}
