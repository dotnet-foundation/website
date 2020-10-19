using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DotnetFoundationWeb
{
    public class SpeakerLinkAttribute : Attribute
    {
        public SpeakerLinkAttribute(string iconClass, bool enforceHttps = true, bool displayOnAddPage = true, string exampleUrl = "", string validationPattern = "")
        {
            IconClass = iconClass;
            EnforceHttps = enforceHttps;
            DisplayOnAddPage = displayOnAddPage;
            ExampleUrl = exampleUrl;
            ValidationPattern = validationPattern;
        }

        public string IconClass { get; set; }

        public bool EnforceHttps { get; set; }

        public bool DisplayOnAddPage { get; set; }
        
        // A friendly example to be displayed in the UI as a reference
        public string ExampleUrl { get; set; }

        // The html5 validation pattern that will be used in the UI
        public string ValidationPattern {get;set;}

        public static Dictionary<string, SpeakerLinkAttribute> GetAll() =>
            typeof(SiteKeys)
                .GetFields()
                .Select(x => (x.Name, x.GetCustomAttribute<SpeakerLinkAttribute>()))
                .Where(x => x.Item2 is object)
                .ToDictionary(x => x.Name, x => x.Item2);
    }
}
