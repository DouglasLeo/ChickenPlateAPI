using System;
using System.ComponentModel.DataAnnotations;

namespace ChikenPlatesApp.Models
{
    public class ChickenPart
    {
        [Key]
        public long Id { get; set; }
        [MaxLength(250)]
        public string PartName { get; set; }

    }
}
