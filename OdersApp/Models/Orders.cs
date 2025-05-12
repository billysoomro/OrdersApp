using System.ComponentModel.DataAnnotations;

namespace OrderApp.Models
{
    public class Orders
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]        
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string Order { get; set; }

        [Required]
        [Range(1, 100)]
        public int OrderQuantity { get; set; }        
    }
}