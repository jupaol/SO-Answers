using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Newtonsoft.Json;
using GlobalTests.Model;
using FluentAssertions;

namespace GlobalTests.Topics.JsonSerialization
{
    [TestClass]
    public class SerializingListsTests
    {
        [TestMethod]
        public void serializing_lists_to_json()
        {
            var countries = new[] { new Country { Name = "USA" }, new Country { Name = "Canada" } };
            
            var json = JsonConvert.SerializeObject(countries);

            Console.WriteLine(json);

            json.Should().NotBeNullOrEmpty().And.NotBeBlank();
        }
    }
}
