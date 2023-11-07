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
            Console.WriteLine("За колко човека вкарваме данни? ");
            int n = int.Parse(Console.ReadLine());
            List<Danni> objects = Danni.CreateObjectsList(n);
            double averageAge = Danni.AverageAge(objects);
            Console.WriteLine($"Средна възраст на подсъдимите: {averageAge}");
        }
    }
}
