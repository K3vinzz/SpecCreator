using System.Reflection;
using OuterSpec;
using OuterSpec.Context;
using OuterSpec.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> _summaries;

        SortedSet<KeyValuePair<int, string[]>> sortedSet = new SortedSet<KeyValuePair<int,string[]>>(new KeyValuePairKeyComparer());

        List<InsFormat> formats = new();

        string fitem = "";
        string ft = "";


        _summaries = SumHelper.LoadSummaries(@"bin\Debug\net8.0\OuterSpec.xml");

        using (var context = new InsFormatContext())
                {
                    var insFormats = context.InsFormats.ToList();
                    var a = from ins in insFormats
                            where ins.Ifcode == 5558  // IFCode
                            select ins;
                    formats = a.ToList();
                }

        // Loop through all the properties in each InsFormat object
        foreach (var format in formats)
        {
            int counter = 0;
            foreach (PropertyInfo property in format.GetType().GetProperties())
            {

                var propertyName = property.Name;
                var propertyValue = property.GetValue(format, null);
                var propertySummary = SumHelper.GetPropertySummary(property, _summaries);


                
                if (counter > 9 && propertyValue is not null && !string.IsNullOrEmpty(propertyValue.ToString()))
                {
                    int key = Convert.ToInt32(propertyValue.ToString()!.TrimEnd(','));
                    var set = new KeyValuePair<int, string[]>(key , [$"{property.Name}", $"{propertySummary}"] );
                    sortedSet.Add(set);
                }
                else if (counter == 2)
                {
                    fitem = propertyValue!.ToString()!;
                }
                else if (counter == 3)
                {
                    ft = propertyValue!.ToString()!;
                }

                counter++;
            }
        }

        Console.WriteLine($"{fitem} 分隔:{ft}");
        foreach (var s in sortedSet)
        {
            Console.WriteLine( $"{s.Key} {s.Value[0]} {s.Value[1]}" );
        }
    }

    private class KeyValuePairKeyComparer : IComparer<KeyValuePair<int, string[]>>
    {
        public int Compare(KeyValuePair<int, string[]> x, KeyValuePair<int, string[]> y)
        {
            // Compare by key only since keys are guaranteed to be unique
            return x.Key.CompareTo(y.Key);
        }
    }
}