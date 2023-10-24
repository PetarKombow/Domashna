using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudebna_zala
{
    internal class Danni
    {
        private string adres;
        private int vuzrast;
        private string mqstonarabota;
        private string sroknaprisuda;

        // Конструктори
        public void Sud(string adres, int vuzrast, string mqstonarabota, string sroknaprisuda)
        {
            this.adres = adres;
            this.vuzrast = vuzrast;
            this.mqstonarabota = mqstonarabota;
            this.sroknaprisuda = sroknaprisuda;
        }
        // Влаидация
        public bool Validaciq()
        {
            if (vuzrast < 18)
            {
                throw new ArgumentOutOfRangeException("Greshka");
            }
            else
            {
                return true;
            }

        }
        public void Chetene()
        {
            Console.Write("Адрес: ");
            adres = Console.ReadLine();
            Console.Write("Възраст: ");
            vuzrast = int.Parse(Console.ReadLine());
            Console.Write("Месторабота: ");
            mqstonarabota = Console.ReadLine();
            Console.Write("Срок на присъда: ");
            sroknaprisuda = Console.ReadLine();
        }

        // Метод за извеждане на данните
        public void Data()
        {
            Console.WriteLine($"Адрес: {adres}");
            Console.WriteLine($"Възраст: {vuzrast}");
            Console.WriteLine($"Месторабота: {mqstonarabota}");
            Console.WriteLine($"Срок на присъда: {sroknaprisuda}");
        }

        public static List<Danni> CreateObjectsList(int n)
        {
            List<Danni> objectsList = new List<Danni>();
            for (int i = 0; i < n; i++)
            {
                Danni obj = new Danni();
                obj.Chetene();
                if (obj.Validaciq())
                {
                    objectsList.Add(obj);
                }
                else
                {
                    Console.WriteLine("Greshka.Otnovo");
                }
            }
            return objectsList;
        }
        public static double FindAverageAge(List<Danni> objectsList)
        {
            if (objectsList.Count == 0)
            {
                return 0;
            }

            int totalAge = 0;
            foreach (Danni obj in objectsList)
            {
                totalAge += obj.vuzrast;
            }

            return (double)totalAge / objectsList.Count;
        }
    }
}
