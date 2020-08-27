using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TVMaze.Models
{
    public class RTLshow
    {
        public int Id { get; set; } = 0;
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = "";
        public List<Cast> Casts { get; set; } = new List<Cast>();
    }
}
