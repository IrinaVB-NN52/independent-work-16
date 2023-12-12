using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Задача_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            Product[] products = new  Product[n];
            for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Введите код товара");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите наименование товара");
                string name = Console.ReadLine();
                Console.WriteLine("Введите цену товара");
                int sum = Convert.ToInt32(Console.ReadLine());

                products[i] = new Product() { Code = code, Name = name, Sum =sum };
            }
            JsonSerializerOptions options = new JsonSerializerOptions()
            {
                    Encoder=JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
            };
             string jsonString = JsonSerializer.Serialize(products, options);

            using (StreamWriter sw = new StreamWriter ("../../../Product.json"))
            {
                sw.WriteLine(jsonString);
            }
        }
    }
}
