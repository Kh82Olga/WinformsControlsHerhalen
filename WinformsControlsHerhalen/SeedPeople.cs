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
        static public List<Person> People { get; }= new List<Person>();
        static public List<Person>GetPeople()
        {
            var p1 = new Person() { Id = 1, FirstName = "Anass", LastName = "ElLAmzi", Age=  27, IsVip=  false, Country=  1 };
            var p2 = new Person() { Id = 2, FirstName = "Florian", LastName = "Esprit", Age = 22, IsVip = true, Country = 2 };
            var p3 = new Person() { Id = 3, FirstName = "Wouter", LastName = "Van Laere", Age = 28, IsVip = false, Country = 3 };
            var p4 = new Person() { Id = 4, FirstName = "Olga", LastName = "Kharchuk", Age = 24, IsVip = true, Country = 1 };
            var p5 = new Person() { Id = 5, FirstName = "Serap", LastName = "Albayrak", Age = 28, IsVip = false, Country = 2 };

            People.Add(p1);
            People.Add(p2);
            People.Add(p3);
            People.Add(p4);
            People.Add(p5);

            return People;
        }

    }
}
