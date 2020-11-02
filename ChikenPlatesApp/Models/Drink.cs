using System.ComponentModel.DataAnnotations;

namespace ChikenPlatesApp.Models
{
    public class Drink
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(250)]
        string DrinkName { get; set; }
    }
}
