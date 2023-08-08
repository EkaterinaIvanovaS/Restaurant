namespace Dal.DbModels
{
    public partial class OrderToProduct
    {
        public int Id { get; set; }
        public int orderId { get; set; }
        public int productId { get; set; }
        public int count { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
