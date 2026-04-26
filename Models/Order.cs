using BlossomAndCo.Enums;

namespace BlossomAndCo.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;

        public DateTime OrderDate { get; set; } = DateTime.Now;
        public decimal TotalAmount { get; set; }
        public OrderStatus Status { get; set; }

        public DeliveryType DeliveryMethod { get; set; } 
        public string? DeliveryAddress { get; set; }
        public DateTime PreferredDeliveryTime { get; set; }
        public string? Comment { get; set; }

        public List<OrderItem> OrderItems { get; set; } = new();
    }
}
