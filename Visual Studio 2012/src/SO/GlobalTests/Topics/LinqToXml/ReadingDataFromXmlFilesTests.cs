using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Linq;
using System.IO;
using System.Linq;
using FluentAssertions;

namespace GlobalTests.Topics.LinqToXml
{
    [TestClass]
    public class ReadingDataFromXmlFilesTests
    {
        private StreamReader GetStream()
        {
            var cd = Directory.GetCurrentDirectory();
            var xmlFile = Path.Combine(cd, "Data\\People.xml");
            var sr = new StreamReader(xmlFile);

            return sr;
        }

        [TestMethod]
        public void ReadingDataFromXmlFile()
        {
            var d = XDocument.Load(this.GetStream());
        }

        [TestMethod]
        public void GetAllCountries()
        {
            var d = XDocument.Load(this.GetStream());

            var q = from c in d.Root.Elements()
                    where c.Name == "Country"
                    select c;

            q.Should().NotBeEmpty().And.HaveCount(4);
        }

        [TestMethod]
        public void GetAllPeopleByCountry()
        {
            var d = XDocument.Load(this.GetStream());
            var c = "France";

            var q = d.Root.Elements().Where(x => x.Name == "Country" && x.Attribute("name").Value == c);
            q.Should().HaveCount(1);

            q = q.Elements().Where(x => x.Name == "Person");
            q.Should().HaveCount(1);

            q = q.Elements().Where(x => x.Name == "Language");
            q.Should().HaveCount(2);
        }
    }
}
