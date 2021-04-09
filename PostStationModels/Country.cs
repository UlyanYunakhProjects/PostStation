using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PostStationModels
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Developer> Developers { get; set; } = new List<Developer>();
    }
}