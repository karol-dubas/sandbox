using System;

namespace JSON
{
    internal class Product
    {
        public string Name { get; set; }
        public DateTime ProductionDate { get; set; }
        public decimal Price { get; set; }
        public string[] Sizes { get; set; }
    }
}