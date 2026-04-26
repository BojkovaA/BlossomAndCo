using BlossomAndCo.Enums;

namespace BlossomAndCo.Models
{
    public class Bouquet:Product
    {
        public BouquetSize Size { get; set; }
        public List<BouquetIngredients> Ingredients { get; set; } = new();
    }
}
