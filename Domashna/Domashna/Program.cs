using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Domashna.Familiq;

namespace Domashna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of family members: ");
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the name of person {i + 1}: ");
                string name = Console.ReadLine();

                Console.Write($"Enter the age of person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                Familiq person = new Familiq(name, age);
                family.AddMember(person);
            }
            /*sortirani po ime
            Console.WriteLine("Ot semeistvoto(sortirani po ime) : ");
            family.PrintFamily();*/
            //sortirane po vuzrast ako sa pod 30
            Console.WriteLine("Ot semeistvoto(sortirani po ime) : ");
            family.PrintFamily();
        }
    }
}