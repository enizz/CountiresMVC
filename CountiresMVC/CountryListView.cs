using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountiresMVC
{
    public class CountryListView
    {
        public CountryListView(List<Country> countries)
        {
            Countries = countries;
        }

        public List<Country> Countries { get; set; }

        public void Display()
        {
            Console.WriteLine("Here is a list of countries: ");

            for (int x = 0; x < Countries.Count; x++)
            {
                Console.WriteLine($"{x+1}. {Countries[x].Name}");
            }
        }
    }
}
