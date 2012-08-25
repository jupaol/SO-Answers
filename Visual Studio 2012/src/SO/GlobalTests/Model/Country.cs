using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTests.Model
{
    public class Country
    {
        public string Name { get; set; }
        public IEnumerable<Person> People { get; set; }
    }
}
