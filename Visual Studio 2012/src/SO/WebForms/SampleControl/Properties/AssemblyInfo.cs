using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Web.UI;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("SampleControl")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Hewlett-Packard")]
[assembly: AssemblyProduct("SampleControl")]
[assembly: AssemblyCopyright("Copyright © Hewlett-Packard 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("9a2700dd-7a3b-4723-9524-1cadbe6ae9fa")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: WebResource("SampleControl.UpdatePanelAnimation.js", "application/x-javascript")]

[assembly: System.Web.UI.WebResource("SampleControl.CheckAnswer.js", "application/x-javascript")]
[assembly: System.Web.UI.ScriptResource(
    scriptName: "SampleControl.CheckAnswer.js", 
    stringResourceName: "SampleControl.VerificationResources", 
    stringResourceClientTypeName: "Answer")]