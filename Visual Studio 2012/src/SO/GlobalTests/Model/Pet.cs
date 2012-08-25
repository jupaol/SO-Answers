using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalTests.Model
{
    public class Pet
    {
        public Person Owner { get; set; }
        public string Name { get; set; }
    }
}
