using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Domashna
{
    internal class Familiq
    {
        public string Name;
        public int Age;

        public Familiq(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public class Family
        {
            public List<Familiq> members;

            public Family()
            {
                members = new List<Familiq>();
            }

            public void AddMember(Familiq hora)
            {
                members.Add(hora);
            }
            public void PrintFamily()
            {
                members.Sort((h1, h2) => string.Compare(h1.Name, h2.Name));
                foreach (var h in members)
                {
                    if (h.Age >= 30) // izkluchva ako sa pod 30 godini
                    {
                        Console.WriteLine($"Name: {h.Name}, Age: {h.Age}");
                    }
                }
            }
        }

    }
    }
