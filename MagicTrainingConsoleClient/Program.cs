using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTrainingConsoleClient
{
    class Program
    {

       
        static void Main(string[] args)
        {
            MagicTrainingConsoleReference.MagicTrainingServiceSoapClient client = new MagicTrainingConsoleReference.MagicTrainingServiceSoapClient();

            List<string> list = client.FindTableNames(); 

            foreach(string str in list)
            {
            Console.WriteLine(str);
            }

            Console.WriteLine("\nMake a choice");
            List<string> list1 = client.FindTableByName(Console.ReadLine());
            foreach (string str in list1)
            {
                Console.WriteLine(str);
            }

            Console.Read();
        }
    }
}
