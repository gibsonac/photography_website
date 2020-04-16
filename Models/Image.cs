using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Photography_Website.Models
{
    public class Image
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string location { get; set; }
        public int category {get;set;}
        // 1 == Underwater
        // 2 == Landscape
        // 3 == Portrait
        public DateTime CreatedAt{get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

    }
}