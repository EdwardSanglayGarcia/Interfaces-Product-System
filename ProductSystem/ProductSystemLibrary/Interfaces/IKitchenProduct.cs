namespace ProductSystemLibrary.Interfaces
{
    public interface IKitchenProduct : IDefaultProduct
    {
        public ICollection<string> SubCategories { get; set; }
    }
}
