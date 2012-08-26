using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebForms_1.Topics.ConfigSettings
{
    public class FontElement : ConfigurationElement
    {
        private const string NameAttributeName = "name";
        private const string SizeAttributeName = "size";

        [ConfigurationProperty(NameAttributeName, IsRequired = true, DefaultValue = "Arial")]
        [StringValidator(InvalidCharacters = "~!@#$%^&*()[]{}/;'\"|\\", MinLength = 5, MaxLength = 60)]
        public string Name
        {
            get
            {
                return (string)this[NameAttributeName];
            }
            set
            {
                this[NameAttributeName] = value;
            }
        }

        [ConfigurationProperty(SizeAttributeName, IsRequired = false, DefaultValue = 11)]
        [IntegerValidator(MinValue = 6, MaxValue = 24, ExcludeRange = false)]
        public int Size
        {
            get
            {
                return (int)this[SizeAttributeName];
            }
            set
            {
                this[SizeAttributeName] = value;
            }
        }
    }
}