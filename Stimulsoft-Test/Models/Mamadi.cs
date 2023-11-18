using System.ComponentModel;

namespace Stimulsoft_Test.Models;

public class Mamadi
{
    [Description("شناسه")]
    public int Id { get; set; }
    [Description("عنوان")]
    public string? Title { get; set; }
    [Description("تاریخ")]
    public string? Created { get; set; }
}
