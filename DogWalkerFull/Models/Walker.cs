using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalkerFull.Models
{
    public class Walker
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Walker Name must be between 2 and 40 characters")]
        public string Name { get; set; }
        [Required]
        public int NeighborhoodId { get; set; }

        public Neighborhood Neighborhood { get; set; }

        public List<Walks> Walks { get; set; }
    }
}
