using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DotnetFoundationWeb
{
    public class SpeakerLinkAttribute : Attribute
    {
        public SpeakerLinkAttribute(string iconClass, bool enforceHttps = true, bool displayOnAddPage = true)
        {
            IconClass = iconClass;
            EnforceHttps = enforceHttps;
            DisplayOnAddPage = displayOnAddPage;
        }

        public string IconClass { get; set; }

        public bool EnforceHttps { get; set; }

        public bool DisplayOnAddPage { get; set; }

        public static Dictionary<string, SpeakerLinkAttribute> GetAll() =>
            typeof(SiteKeys)
                .GetFields()
                .Select(x => (x.Name, x.GetCustomAttribute<SpeakerLinkAttribute>()))
                .Where(x => x.Item2 is object)
                .ToDictionary(x => x.Name, x => x.Item2);
    }
}
