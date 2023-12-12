using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Задача_16._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string jsonString = String.Empty;
            using (StreamReader sr = new StreamReader("../../../Product.json"))
            {
                jsonString = sr.ReadToEnd();
            }
            Product[] products = JsonSerializer.Deserialize<Product[]>(jsonString);
            Product maxProduct = products[0];
            foreach (Product e in products)

            {
                if(e.Sum > maxProduct.Sum )
                {
                    maxProduct = e;
                }
            }
            Console.WriteLine($"{maxProduct.Code } {maxProduct.Name } {maxProduct.Sum}");
            Console.ReadKey();
        }
    }
}
