using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            this.CreatedAt = DateTime.Now;
        }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }


}


