using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DogWalkerFull.Models
{
    public class Owner
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(40, MinimumLength = 2, ErrorMessage = "Owner Name must be between 2 and 40 characters")]

        public string Address { get; set; }
        public int NeighborhoodId { get; set; }
        public string Phone { get; set; }
        [Required]
        public Neighborhood Neighborhood { get; set; }
        public List<Dog> Dogs { get; set; }
 

    }
}
