﻿using System;
using System.ComponentModel.DataAnnotations;

namespace ChikenPlatesApp.Models
{
    public class SideDish
    {
        [Key]
        public long Id { get; set; }
        
        [Required]
        [MaxLength(250)]
        public string DishName { get; set; }
    }
}
