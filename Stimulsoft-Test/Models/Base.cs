using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Stimulsoft_Test.Models;

public class Base
{
    [Description("شناسه")]
    public int Id { get; set; }
    [Description("نام")]
    public string FirstName { get; set; }
    [Description("نام خانوادگی")]
    public string LastName { get; set; }
    [Description("تاریخ تولد")]
    public string Birthday { get; set; }
}
