using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecture { get; set; }
        [Required]
        public string LectureID { get; set; }
        [Required]
        [StringLength(255)]
        public string Place { get; set; }
        public DateTime Datetime { get; set; }
        public byte Category { get; set; }

        [Required]
        public string CategoryID { get; set; }
    }
}