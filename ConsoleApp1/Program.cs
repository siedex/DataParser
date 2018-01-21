using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataParser;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = DataCollector.CollectFromOLX(20);
            result.ToList().ForEach(model =>
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(model.Url);
                model.CollectPhones();
                model.Phones?.ToList().ForEach(phone => Console.WriteLine(phone));
                Console.WriteLine("-----------------------------------------");
            });

            DataCollector.FreeResources();

            Console.WriteLine("DONE");

            Console.ReadLine();
            return;
        }
    }
}
