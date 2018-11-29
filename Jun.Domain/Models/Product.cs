using System;
using System.Collections.Generic;
using System.Text;

namespace Jun.Domain.Models
{
    public class Product:BaseModel
    {
        public string Name { get; set; }
        public DateTime CreateDateTime { get; set; }
    }
}
