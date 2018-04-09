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
            var result = DataCollector.CollectFromOLX();
            result.ToList().ForEach(model =>
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine(model.Url);

                var phones = model.CollectPhones();
                if (phones != null && phones.Count() > 0)
                    phones.ToList().ForEach(phone => Console.WriteLine(phone));
                else
                    Console.WriteLine("No phones");
                
                Console.WriteLine("-----------------------------------------");
            });

            DataCollector.FreeResources();

            Console.WriteLine("DONE");

            Console.ReadLine();
            return;
        }
    }
}
