using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace src.Enum
{
    public enum CustomerType
    {
        [Display(Name = "Administrator")]
        Dept0 = 0,
        [Display(Name = "Accounting")]
        Dept1 = 1,
        [Display(Name = "CSO")]
        Dept2 = 2,
        [Display(Name = "Digital Business")]
        Dept3 = 3,
        [Display(Name = "Finance")]
        Dept4 = 4,
        [Display(Name = "Fix Income")]
        Dept5 = 5,
        [Display(Name = "GA")]
        Dept6 = 6,
        [Display(Name = "HRD")]
        Dept7 = 7,
        [Display(Name = "IT")]
        Dept8 = 8,
        [Display(Name = "IB")]
        Dept9 = 9,
        [Display(Name = "InHouse")]
        Dept10 = 10,
        [Display(Name = "Institusi")]
        Dept11 = 11,
        [Display(Name = "Legal")]
        Dept12 = 12,
        [Display(Name = "Purchasing")]
        Dept13 = 13,
        [Display(Name = "RM")]
        Dept14 = 14,
        [Display(Name = "Research")]
        Dept15 = 15,
        [Display(Name = "Settlement")]
        Dept16 = 16,
        [Display(Name = "Strategic Sales")]
        Dept17 = 17,
        [Display(Name = "WMAI")]
        Dept18 = 18,
        [Display(Name = "Other")]
        Dept19 = 19,
    }
}
