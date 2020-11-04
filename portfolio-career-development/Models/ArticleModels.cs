using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace portfolio_career_development.Models
{
    public class Article
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Please Enter the Title !")]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "News Title")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Please Enter the Content !.")]
        [DataType(DataType.MultilineText)]
        [Display(Name = "News Content")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Enter the created date.")]
        [Display(Name = "Create Date")]
        [DataType(DataType.Date)]
        public DateTime DateTimeCreated { get; set; }

       
    }
}