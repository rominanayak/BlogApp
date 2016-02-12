using System;
using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class Comment
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        public Blog blog { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DateTime { get; set; }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Body { get; set; }

        public Comment()
        {
            DateTime = DateTime.Now;
        }
    }
}