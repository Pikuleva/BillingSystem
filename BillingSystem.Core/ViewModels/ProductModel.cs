namespace BillingSystem.Core.ViewModels
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }= string.Empty;
        public decimal  Price { get; set; }
        public TypeOfServiceModel Type { get; set; } = null!;
        public int TypeId { get; set; }
    }
}
