using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataLinq.CustomDataContextMetadata
{
    public class JobsMetadata
    {
        [UIHint("MyCustomFieldTemplate")]
        public object job_desc { get; set; }
    }
}