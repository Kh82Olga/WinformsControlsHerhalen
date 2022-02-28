using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsControlsHerhalen
{
    public class SeedPeople
    {
        //static public List<Person> People = new List<Person>();
        static private List<Person> list { get; set; }
        static public List<Person> People
        {
            get 
            { 
                return GetPeople(); 
            }
        }

        static private List<Person>GetPeople()
        {
            list = new List<Person>();
            var p1 = new Person() { Id = 1, FirstName = "Anass", LastName = "ElLAmzi", Age=  27, IsVip=  false, Country=  1 };
            var p2 = new Person() { Id = 2, FirstName = "Florian", LastName = "Esprit", Age = 22, IsVip = true, Country = 2 };
            var p3 = new Person() { Id = 3, FirstName = "Wouter", LastName = "Van Laere", Age = 28, IsVip = false, Country = 3 };
            var p4 = new Person() { Id = 4, FirstName = "Olga", LastName = "Kharchuk", Age = 24, IsVip = true, Country = 1 };
            var p5 = new Person() { Id = 5, FirstName = "Serap", LastName = "Albayrak", Age = 28, IsVip = false, Country = 2 };

            list.Add(p1);
            list.Add(p2);
            list.Add(p3);
            list.Add(p4);
            list.Add(p5);

            return list;
        }

    }
}
