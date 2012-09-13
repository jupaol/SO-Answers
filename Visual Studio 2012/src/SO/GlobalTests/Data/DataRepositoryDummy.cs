using GlobalTests.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GlobalTests.Data
{
    public class DataRepositoryDummy
    {
        private List<Country> countries;
        private IEnumerable<Person> peopleWithPets;
        private IEnumerable<Pet> pets;

        public DataRepositoryDummy()
        {
            this.countries = new List<Country>();

            var d = XDocument.Load(this.GetStream());

            this.countries.AddRange(d.Root.Elements().Where(x => x.Name == "Country").Select(x => new Country
                {
                    Name = x.Attribute("name").Value,
                    People = x.Elements().Where(z => z.Name == "Person").Select(z => new Person
                    {
                        Name = z.Attribute("name").Value,
                        Age = int.Parse(z.Attribute("age").Value),
                        LanguagesSpoken = z.Elements().Where(c => c.Name == "Language").Select(c =>
                        (Language)Enum.Parse(typeof(Language), c.Attribute("name").Value))
                    })
                }));

            var jon = new Person { Name = "Jon"};
            var jpol = new Person { Name = "JPOL", LanguagesSpoken = new[] { Language.English, Language.Spanish } };
            var paul = new Person { Name = "Paul" };
            var pepe = new Person { Name = "Pepe" };

            var bimombambin = new Pet { Name = "bimbombambin", Owner = jpol };
            var tita = new Pet { Name = "tita", Owner = pepe };
            var chofi = new Pet { Name = "chofi", Owner = pepe };
            var elliot = new Pet { Name = "elliot", Owner = jon };
            var helmer = new Pet { Name = "helmer", Owner = jon };
            var chester = new Pet { Name = "chester", Owner = jpol };

            this.peopleWithPets = new[] { jon, jpol, paul, pepe };
            this.pets = new[] { bimombambin, tita, chofi, elliot, helmer, chester };
        }

        public IEnumerable<Country> GetCountries()
        {
            return this.countries;
        }

        public IEnumerable<Person> GetPeopleWithPets()
        {
            return this.peopleWithPets;
        }

        public IEnumerable<Pet> GetPets()
        {
            return this.pets;
        }

        private StreamReader GetStream()
        {
            var cd = Directory.GetCurrentDirectory();
            var xmlFile = Path.Combine(cd, "Data\\People.xml");
            var sr = new StreamReader(xmlFile);

            return sr;
        }
    }
}
