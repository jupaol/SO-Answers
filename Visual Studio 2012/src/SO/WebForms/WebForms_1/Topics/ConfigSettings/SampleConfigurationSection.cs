using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebForms_1.Topics.ConfigSettings
{
    public class SampleConfigurationSection : ConfigurationSection
    {
        private const string RemoteOnlyElementName = "remoteOnly";
        private const string FontElementName = "font";
        private const string ColorElementName = "color";

        [ConfigurationProperty(RemoteOnlyElementName, DefaultValue = false, IsRequired = false)]
        public bool RemoteOnly
        {
            get
            {
                return (bool)this[RemoteOnlyElementName];
            }
            set
            {
                this[RemoteOnlyElementName] = value;
            }
        }

        [ConfigurationProperty(FontElementName, IsRequired = true)]
        public FontElement Font
        {
            get
            {
                return (FontElement)this[FontElementName];
            }
            set
            {
                this[FontElementName] = value;
            }
        }

        [ConfigurationProperty(ColorElementName, IsRequired = true)]
        public ColorElement Color
        {
            get
            {
                return (ColorElement)this[ColorElementName];
            }
            set
            {
                this[ColorElementName] = value;
            }
        }
    }
}