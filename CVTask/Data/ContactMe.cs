using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CVTask.Data
{
    public class ContactMe
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:15, MinimumLength =2)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength:20, MinimumLength =2)]
        public string Subject { get; set; }
        [Required]
        [MinLength(20)]
        public string Message { get; set; }
    }
}