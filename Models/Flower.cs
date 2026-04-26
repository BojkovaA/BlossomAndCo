namespace BlossomAndCo.Models
{
    public class Flower:Product
    {
        public string FlowerFamily { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public bool IsFragrant { get; set; }
    }
}
