using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace portfolio_career_development.Models
{
    public class Webinar
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter the Topic !")]
        [StringLength(60, MinimumLength = 3)]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Please Enter the what webinar about.")]
        [DataType(DataType.MultilineText)]
        public string About { get; set; }

        [Required(ErrorMessage = "Enter the webinar date.")]
        [Display(Name = "Webinar Date")]
        [DataType(DataType.Date)]
        public DateTime DateWebinar { get; set; }
    }
}