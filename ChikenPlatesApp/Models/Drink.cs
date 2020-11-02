using System.ComponentModel.DataAnnotations;

namespace ChikenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        string DrinkName { get; set; }
        public ChickenPlate ChickenPlate { get; set; }
        public long ChickenPlateId { get; set; }
    }   
}
