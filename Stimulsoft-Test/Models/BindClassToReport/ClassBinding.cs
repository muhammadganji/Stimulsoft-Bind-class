using System.ComponentModel;
using System.Reflection;

namespace Stimulsoft_Test.Models.BindClassToReport;

public static class ClassBinding
{
    /// <summary>
    /// convert class to list of property
    /// </summary>
    /// <typeparam name="T">Target type class</typeparam>
    /// <param name="obj">Target class</param>
    /// <returns>List of property</returns>
    public static List<Result> GetDescription<T>(T obj)
    {
        List<Result> results = new List<Result>();

        Type objType = typeof(T);
        PropertyInfo[] properties = objType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

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


/// <summary>
/// base class property
/// </summary>
public class Result
{
    /// <summary>
    /// Header of table
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Name of property
    /// </summary>
    public string Property { get; set; }
    /// <summary>
    /// Type of peroperty
    /// </summary>
    public string Type { get; set; }
}