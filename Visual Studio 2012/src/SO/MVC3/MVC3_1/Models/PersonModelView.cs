using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC3_1.Models
{
    public class PersonModelView
    {
        public string Name { get; set; }

        [UIHint("AgeDisplay")]
        public DateTime? Birtday { get; set; }
    }
}