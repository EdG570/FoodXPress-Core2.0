using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FoodXPress.Models
{
    public enum Category
    {
        Drink,
        Meal,
        Appetizer,
        Side,
        Dessert
    }

    public class FoodItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public Category Category { get; set; }
    }
}
