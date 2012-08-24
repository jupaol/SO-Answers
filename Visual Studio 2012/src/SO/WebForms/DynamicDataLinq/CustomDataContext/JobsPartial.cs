using DynamicDataLinq.CustomDataContextMetadata;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DynamicDataLinq.CustomDataContext
{
    [MetadataType(typeof(JobsMetadata))]
    public partial class jobs
    {
    }
}