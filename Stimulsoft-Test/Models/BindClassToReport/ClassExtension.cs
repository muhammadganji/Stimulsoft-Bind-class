using System.ComponentModel;
using System.Reflection;

namespace Stimulsoft_Test.Models.BindClassToReport;

public static class ClassExtension
{
    public static List<Result> GetDescription(Mamadi mamadi)
    {
        List<Result> results = new List<Result>();

        Type mamadiType = typeof(Mamadi);
        PropertyInfo[] properties = mamadiType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

        foreach (PropertyInfo property in properties)
        {
            DescriptionAttribute descriptionAttribute = property.GetCustomAttribute<DescriptionAttribute>();
            if (descriptionAttribute != null)
            {
                Result result = new Result
                {
                    Description = descriptionAttribute.Description,
                    Property = property.Name,
                    Type = property.PropertyType.Name
                };
                results.Add(result);
            }
        }

        return results;
    }
}

public class Result
{
    public string Description { get; set; }
    public string Property { get; set; }
    public string Type { get; set; }
}