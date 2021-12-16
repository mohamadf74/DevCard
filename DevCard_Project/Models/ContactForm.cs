using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Project.Models
{
    public class ContactForm
    {
        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [MinLength(3,ErrorMessage = "حداقل طول باید 3 باشد")]
        public string name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        [EmailAddress(ErrorMessage = "شکل ایمیل صحیح نم باشد")]
        public string email { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string service { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است.")]
        public string message { get; set; }
    }
}
