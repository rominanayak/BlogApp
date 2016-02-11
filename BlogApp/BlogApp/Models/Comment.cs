using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bloggingPortal.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public Guid Id { get; set; }

        [ScaffoldColumn(false)]
        public Blog blog { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedOn { get; set; }

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required]
        public string Body { get; set; }

        public Comment()
        {
            CreatedOn = DateTime.Now;
        }
    }
}