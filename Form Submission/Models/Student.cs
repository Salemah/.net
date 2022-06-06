using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Form_Submission.Models
{
    public class Student
    {
        [Required]
        [StringLength(20, ErrorMessage = "Name lenght must not exceed 20")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^\d{2}-\d{5}-[1-3]$", ErrorMessage = "Id must follow XX-XXXXX-X")]
        public string Id { get; set; }
        [Required]
        public string Dob { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
         [Required]
        public string Department { get; set; }
        }
}