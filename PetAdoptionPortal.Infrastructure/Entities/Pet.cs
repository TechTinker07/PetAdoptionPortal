using System.ComponentModel.DataAnnotations;

namespace PetAdoptionPortal.Infrastructure.Entities
{
    public class Pet
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(50)]
        public string Species { get; set; }

        [Range(0, 50, ErrorMessage = "Age must be between 0 and 50.")]
        public int Age { get; set; }

        [MaxLength(10)]
        public string Gender { get; set; }

        [MaxLength(200)]
        public string Personality { get; set; }

        public string ImageUrl { get; set; }

        //available 
        public string Status { get; set; } = "Available";
    }
}
