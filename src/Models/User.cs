using src.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace src.Models
{
    public class User : BaseEntity
    {
        public User()
        {
            this.thumburl = "/images/no-image-available.png";
        }

        public int id { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
        [StringLength(200)]

        [Display(Name = "User Name")]
        public string username { get; set; }
        [StringLength(200)]

        [Display(Name = "Branch")]
        public Enum.Branches branches { get; set; }

        [Display(Name = "Department")]
        public Enum.Department department { get; set; }

        [Display(Name = "Phone")]
        public int phone { get; set; }

        [Display(Name = "IsActive")]
        public bool isactive { get; set; }

        [Display(Name = "Created Date")]
        public string createddate { get; set; }
        [StringLength(20)]

        [Display(Name = "Created By")]
        public string createdby { get; set; }
        [StringLength(200)]

        public Guid organizationid { get; set; }

        [Display(Name = "Thumb Url")]
        public string thumburl { get; set; }

        public ICollection<User> users { get; set; }
    }
}
