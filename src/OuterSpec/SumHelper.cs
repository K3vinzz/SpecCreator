using System.Reflection;
using System.Xml.Linq;

namespace OuterSpec;

public class SumHelper
{
    public static Dictionary<string, string> LoadSummaries(string xmlPath)
    {
        var summaries = new Dictionary<string, string>();

        XDocument doc = XDocument.Load(xmlPath);
        var members = doc.Descendants("member");

        foreach (var member in members)
        {
            var name = member.Attribute("name").Value;
            var summary = member.Descendants("summary").FirstOrDefault()?.Value.Trim();
            if (summary != null)
            {
                summaries[name] = summary;
            }
        }

        return summaries;
    }

    public static string GetPropertySummary(PropertyInfo property, Dictionary<string, string> summaries)
    {
        string key = $"P:{property.DeclaringType.FullName}.{property.Name}";
        summaries.TryGetValue(key, out string summary);
        return summary;
    }
}
