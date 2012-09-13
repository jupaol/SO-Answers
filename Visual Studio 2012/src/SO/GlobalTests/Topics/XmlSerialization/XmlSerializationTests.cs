using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using GlobalTests.Model;
using System.IO;
using GlobalTests.Data;
using System.Text;
using FluentAssertions;

namespace GlobalTests.Topics.XmlSerialization
{
    [TestClass]
    public class XmlSerializationTests
    {
        [TestMethod]
        public void it_should_serialize_and_deserialize_the_Person_object()
        {
            var ser = new XmlSerializer(typeof(Person));
            var stream = new MemoryStream();
            var dataManager = new DataRepositoryDummy();
            var people = dataManager.GetPeopleWithPets();
            var person = people.First(x => x.Name.ToLower() == "jpol");

            // person.Nickname = "octopus";

            ser.Serialize(stream, person);
            var xml = UTF8Encoding.UTF8.GetString(stream.ToArray());
            xml.Should().NotBeBlank();
            Console.WriteLine(xml);

            stream.Seek(0, SeekOrigin.Begin);
            var reader = new StreamReader(stream);
            var xmlRead = reader.ReadToEnd();
            xml.Should().Be(xmlRead);

            stream.Seek(0, SeekOrigin.Begin);
            var deserializedPerson = ser.Deserialize(new StreamReader(stream)) as Person;
            deserializedPerson.Should().NotBeNull();
            deserializedPerson.Name.Should().Be(person.Name);
        }
    }
}
