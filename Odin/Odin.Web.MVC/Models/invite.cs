using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Odin.Web.MVC.Models
{
    public class invite
    {
        [Required(ErrorMessage ="pls enter name")]
        public  string Name { get; set; }
        [Required(ErrorMessage ="pls enter phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="pls enter attending")]
        public bool? Attending { get; set; }
    }
}