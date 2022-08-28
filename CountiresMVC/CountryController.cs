using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountiresMVC
{
    public class CountryController
    {
        public List<Country> CountryDB { get; set; } = new List<Country>()
        {
            new Country("Algeria", "Africa", new List<string>(){"green", "red", "white"}),
            new Country("Papua New Guinea", "Oceania", new List<string>(){"black", "red", "yellow"}),
            new Country("Moldova", "Europe", new List<string>(){"blue", "yellow", "red"})
        };
        public void CountryAction(Country c)
        {
            var x = new CountryView(c);
            x.Display();
        }
        public void WelcomeAction()
        {
            Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list.");
            var viewList = new CountryListView(CountryDB);
            viewList.Display();
            Console.WriteLine("Please select 1 - " + viewList.Countries.Count + ":");
            int input = int.Parse(Console.ReadLine()) - 1;
            CountryAction(CountryDB[input]);
        }
    }
}
