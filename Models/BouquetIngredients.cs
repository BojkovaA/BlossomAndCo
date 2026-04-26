namespace BlossomAndCo.Models
{
    public class BouquetIngredients
    {
        public int Id { get; set; }

        public int BouquetId { get; set; } 
        public Bouquet Bouquet { get; set; } = null!;

        public int FlowerId { get; set; } 
        public Flower Flower { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
