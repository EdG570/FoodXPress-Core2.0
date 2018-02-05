using System.Collections;
using System.Collections.Generic;

namespace FoodXPress.Models
{
    public class Order
    {
        public int Id { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}