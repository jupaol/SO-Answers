using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebForms_1.Topics.JQuery
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestWcfServiceFromAjax" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestWcfServiceFromAjax.svc or TestWcfServiceFromAjax.svc.cs at the Solution Explorer and start debugging.
    public class TestWcfServiceFromAjax : ITestWcfServiceFromAjax
    {
        public string HelloWorld()
        {
            return "Hello World!";
        }
    }
}
