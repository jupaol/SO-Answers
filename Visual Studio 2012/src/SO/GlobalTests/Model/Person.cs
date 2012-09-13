using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GlobalTests.Model
{
    public class Person
    {
        [XmlAttribute]
        public int PersonID { get; set; }

        [XmlElement("FullName")]
        public string Name { get; set; }
        
        public int Age { get; set; }

        public string Nickname { get; set; }

        [XmlIgnore]
        public IEnumerable<Language> LanguagesSpoken { get; set; }
    }
}
