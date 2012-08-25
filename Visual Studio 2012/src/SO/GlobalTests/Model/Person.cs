using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTests.Model
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public IEnumerable<Language> LanguagesSpoken { get; set; }
    }
}
