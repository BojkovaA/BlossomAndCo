namespace BlossomAndCo.Models
{
    public class Plant:Product
    {
        public string CareInstructions  { get; set; } = string.Empty;
        public string Origin { get; set; } = string.Empty;
        public string SunlightRequirement { get; set; } = string.Empty;
        
    }
}
