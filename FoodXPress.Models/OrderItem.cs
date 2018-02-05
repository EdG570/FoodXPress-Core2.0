using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FoodXPress.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public virtual FoodItem FoodItem { get; set; } 
        public virtual Order Order { get; set; }
    }
}
