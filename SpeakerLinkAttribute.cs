using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DotnetFoundationWeb
{
    public class SpeakerLinkAttribute : Attribute
    {
        public SpeakerLinkAttribute(string iconClass)
        {
            IconClass = iconClass;
        }

        public string IconClass { get; set; }

        public static Dictionary<string, SpeakerLinkAttribute> GetAll() =>
            typeof(SiteKeys)
                .GetFields()
                .Select(x => (x.Name, x.GetCustomAttribute<SpeakerLinkAttribute>()))
                .Where(x => x.Item2 is object)
                .ToDictionary(x => x.Name, x => x.Item2);
    }
}
