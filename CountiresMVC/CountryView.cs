using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountiresMVC
{
    public class CountryView
    {
        public CountryView(Country country)
        {
            DisplayCountry = country;
        }
        public Country DisplayCountry { get; set; }
        
        public void Display()
        {
            string countrycolors = "";
                DisplayCountry.Colors.ForEach(x => countrycolors += x + " ");    
            Console.WriteLine("Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);
            Console.WriteLine("Colors: " + countrycolors);
        }


    }
}
