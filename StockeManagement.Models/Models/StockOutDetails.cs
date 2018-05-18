namespace StockeManagement.Models.Models
{
    public class StockOutDetails
    {
        public int Id { get; set; }
        public int StockOutId { get; set; }
        public int ProductId { get; set; }
        public int Qty { get; set; }
        public StockOut StockOut { get; set; }
        public Product Product { get; set; }
    }
}