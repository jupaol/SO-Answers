using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebForms_1.CustomDataContextMetadata
{
    public class JobsMetadata
    {
        [UIHint("CustomJobDescription")]
        [Required]
        public object job_desc { get; set; }
    }
}