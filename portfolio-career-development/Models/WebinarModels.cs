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
        [Display(Name = "Course")]
        public string Topic { get; set; }

        [Required(ErrorMessage = "Please Enter the what Course about.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "Course Details")]
        public string About { get; set; }

        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:C0}")]
        [Required(ErrorMessage = "Please Enter the Course Price !")]
        [Display(Name = "Course Price")]
        public float CoursePrice { get; set; }

        [Required(ErrorMessage = "Enter the Course starting date.")]
        [Display(Name = "Course Starting Date")]
        [DataType(DataType.Date)]
        public DateTime DateWebinar { get; set; }
    }
}