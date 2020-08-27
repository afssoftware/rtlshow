using System;
using System.ComponentModel.DataAnnotations;

namespace TVMaze.Models
{
    public class Cast
    {
        [Key]
        public int Id { get; set; } = 0;
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = "";
        
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Birthday { get; set; }
    }
}
