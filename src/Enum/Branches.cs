using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace src.Enum
{
    public enum Branches
    {
        [Display(Name = "Head Office")]
        branch0 = 0,

        [Display(Name = "Bali")]
        branch1 = 1,

        [Display(Name = "Bandung")]
        branch2 = 2,

        [Display(Name = "Banjarmasin")]
        branch3 = 3,

        [Display(Name = "Gading Serpong")]
        branch4 = 4,

        [Display(Name = "Jakarta Institutional Division")]
        branch5 = 5,

        [Display(Name = "Jakarta Strategic Division")]
        branch6 = 6,

        [Display(Name = "Jambi")]
        branch7 = 7,

        [Display(Name = "Kelapa Gading")]
        branch8 = 8,

        [Display(Name = "Makassar")]
        branch9 = 9,

        [Display(Name = "Malang")]
        branch10 = 10,

        [Display(Name = "Manado")]
        branch11 = 11,

        [Display(Name = "Medan")]
        branch12 = 12,

        [Display(Name = "Padang")]
        branch13 = 13,

        [Display(Name = "Palembang")]
        branch14 = 14,

        [Display(Name = "Pantai Indah Kapuk")]
        branch15 = 15,

        [Display(Name = "Pekanbaru")]
        branch16 = 16,

        [Display(Name = "Pluit")]
        branch17 = 17,

        [Display(Name = "Pontianak")]
        branch18 = 18,

        [Display(Name = "Puri Indah")]
        branch19 = 19,

        [Display(Name = "Semarang")]
        branch20 = 20,

        [Display(Name = "Solo")]
        branch21 = 21,

        [Display(Name = "Sudirman")]
        branch22 = 22,

        [Display(Name = "Surabaya")]
        branch23 = 23,

        [Display(Name = "Yogyakarta")]
        branch24 = 24
    }
}
