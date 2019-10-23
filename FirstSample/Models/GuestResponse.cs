using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstSample.Models
{
    public class GuestResponse
    {


        //{0} gives property name
        [Required(ErrorMessage ="{0} Required")]
        [DisplayName("Full Name")]
        [StringLength(160, MinimumLength = 8)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        //Compares to Email variable
        [EmailAddress]
        [Compare("Email")]
        public string ConfirmEmail { get; set; }
        public string Phone { get; set; }
        [Range(18, 120)]
        public int Age { get; set; }
        [Required]
        public bool? WillAttend { get; set; }

        //??? Private Within Model??
    }
}
    