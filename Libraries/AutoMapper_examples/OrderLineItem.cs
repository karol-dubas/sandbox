namespace AutoMapper_examples
{
    public class OrderLineItem
    {
        public OrderLineItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        private Product Product { get; }
        private int Quantity { get; }

        public decimal GetTotal()
        {
            return Quantity * Product.Price;
        }
    }
}