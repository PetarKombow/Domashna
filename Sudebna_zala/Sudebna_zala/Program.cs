using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudebna_zala
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko puti ");
            int n = int.Parse(Console.ReadLine());
            List<Danni> objects = Danni.CreateObjectsList(n);
            double averageAge = Danni.FindAverageAge(objects);
            Console.WriteLine($"Средна възраст на обектите: {averageAge}");
        }
    }
}
