using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsControlsHerhalen
{
    public class SeedCountry
    {
        public SeedCountry()
        {
            listCountries = new List<Country>();
        }
        public List<Country> listCountries { get; set; }
        

        public List<Country> Countries
        {
            get 
            { 
                return GetCountries(); 
            }
            
        }

        public List<Country>GetCountries()
        {
            listCountries= new List<Country>();
            var c1 = new Country() { Id = 1, Name = "Belgium" };
            var c2 = new Country() { Id = 2, Name = "France" };
            var c3 = new Country() { Id = 3, Name = "UK" };
            var c4 = new Country() { Id = 4, Name = "Germany" };

            listCountries.Add(c1);
            listCountries.Add(c2);
            listCountries.Add(c3);
            listCountries.Add(c4);

            return listCountries;
        }
    }
}
