using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOffers.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Job Type")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name = "Job Dessription")]
        public string CategoryDessription { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}