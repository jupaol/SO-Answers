using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebForms_1.Topics.ConfigSettings
{
    public class ColorElement : ConfigurationElement
    {
        private const string BackgroundAttributeName = "background";
        private const string ForegroundAttributeName = "foreground";

        [ConfigurationProperty(BackgroundAttributeName, IsRequired = false, DefaultValue = "#000000")]
        [StringValidator(InvalidCharacters = "~!@$%^&*()[]{}/;'\"|\\", MaxLength = 7)]
        public string Background
        {
            get
            {
                return (string)this[BackgroundAttributeName];
            }
            set
            {
                this[BackgroundAttributeName] = value;
            }
        }

        [ConfigurationProperty(ForegroundAttributeName, DefaultValue = "#ffffff", IsRequired = true)]
        [StringValidator(InvalidCharacters = "~!@$%^&*()[]{}/;'\"|\\", MaxLength = 7)]
        public string Foreground
        {
            get
            {
                return (string)this[ForegroundAttributeName];
            }
            set
            {
                this[ForegroundAttributeName] = value;
            }
        }
    }
}