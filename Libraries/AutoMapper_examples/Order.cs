using System.Collections.Generic;
using System.Linq;

namespace AutoMapper_examples
{
    public class Order
    {
        private readonly IList<OrderLineItem> _orderLineItems = new List<OrderLineItem>();
        public Customer Customer { get; set; }

        // zwraca sumę zamówienia np. (4 * 1.49) + (15 * 4.99)
        public decimal Total => _orderLineItems.Sum(li => li.GetTotal());

        public OrderLineItem[] GetOrderLineItems()
        {
            return _orderLineItems.ToArray();
        }

        public void AddOrderLineItem(Product product, int quantity)
        {
            _orderLineItems.Add(new OrderLineItem(product, quantity));
        }

        // może być też GetTotal() i AutoMapper sam dopasuje się do prop Total
        //public decimal GetTotal()
        //{
        //    return _orderLineItems.Sum(li => li.GetTotal());
        //}
    }
}