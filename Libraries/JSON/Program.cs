using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace JSON
{
    internal class Program
    {
        public static Product Product =>
            new Product
            {
                Name = "Apple",
                Price = 399.99M,
                ProductionDate = DateTime.Now,
                Sizes = new[] { "Small", "Medium" }
            };

        private static void Main()
        {
            TwoWayConversion();
            SaveToFile();
        }

        private static void TwoWayConversion()
        {
            string output = JsonConvert.SerializeObject(Product);
            Product deserialized = JsonConvert.DeserializeObject<Product>(output);
        }

        private static void SaveToFile()
        {
            var serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());

            string path = @$"{Environment.CurrentDirectory}\json.txt";
            using var sw = new StreamWriter(path);
            using JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, Product);
        }
    }
}