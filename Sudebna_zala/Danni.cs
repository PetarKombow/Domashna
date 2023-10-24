using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Sudebna_zala
{
    internal class Danni
    {
        private string adress;
        public string Adress
        {
            get { return adress; }
            set { adress = value; }
        }

        public int age
        {
            get { return age; }
            set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException("Greshka");
                }
            }

        }

        public string Mqstonarabota
        {
            get { return Mqstonarabota; }
            set { Mqstonarabota = value; }
        }

        public string Sroknaprisuda
        {
            get { return Sroknaprisuda; }
            set { Sroknaprisuda = value; }
        }

        public void Sud(string adress, int age, string mqstonarabota, string sroknaprisuda)
        {
            this.adress = adress;
            this.age = age;
            this.Mqstonarabota = mqstonarabota;
            this.Sroknaprisuda = sroknaprisuda;
        }
        public  void Sudebna_zala()
         {

         }
        public bool validaciq()
        {
            return true;
        }
        public void read()
        {
            Console.WriteLine("Adress");
            adress =  Console.ReadLine();
            Console.WriteLine("Age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Mqstonarabota");
            Mqstonarabota = Console.ReadLine();
            Console.WriteLine("Srok");
            Sroknaprisuda = (Console.ReadLine());
        }
        public void ekran()
        {
            Console.WriteLine($"Adress : {adress}");
            Console.WriteLine($"Age : {age}");
            Console.WriteLine($"mqsto na rabota : {Mqstonarabota}");
            Console.WriteLine($"Srok n aprisuda : {Sroknaprisuda}");
        }
    }
   
}
