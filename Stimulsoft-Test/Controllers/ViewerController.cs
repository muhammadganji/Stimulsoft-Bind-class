using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Base;
using Stimulsoft.Report;
using Stimulsoft.Report.Mvc;
using Stimulsoft_Test.Models;
using Stimulsoft_Test.Models.BindClassToReport;

namespace Stimulsoft_Test.Controllers
{
    public class ViewerController : Controller
    {
        private readonly IWebHostEnvironment _host;
        public ViewerController(IWebHostEnvironment host)
        {
            _host = host;
            // How to Activate
            //Stimulsoft.Base.StiLicense.Key = "6vJhGtLLLz2GNviWmUTrhSqnO...";
            //Stimulsoft.Base.StiLicense.LoadFromFile("license.key");
            //Stimulsoft.Base.StiLicense.LoadFromStream(stream);
        }

        public IActionResult Index()
        {

            //var mamadi = new Mamadi();
            //var result = ClassBinding.GetDescription(mamadi);
            //string viewbag = "";
            //foreach (var item in result)
            //    viewbag += $"{item.Property}: {item.Description} \n";
            //ViewBag.Test = $"Start analyze: {viewbag}";
            return View();
        }

        public IActionResult GetReport()
        {
            //return null;
            var Address = "Reports/Report_Generaljson.mrt";
            var mamadi = GetDataMamadi(); //GetDataBase(); 

            // Create the report object
            var report = new StiReport();
            //var modelBinding = ClassBinding.GetDescription(new Mamadi()); //ClassBinding.GetDescription(new Base());
            //var classReport = new ClassReport();
            //var jsonReport = classReport.GetAll(modelBinding);
            //report.LoadFromJson(jsonReport);

            report.Load(StiNetCoreHelper.MapPath(this, Address));
            report.Compile();
            report.RegData("dt", mamadi);
            return StiNetCoreViewer.GetReportResult(this, report);

        }

        private static List<Mamadi> GetDataMamadi()
        {
            return new List<Mamadi>()
            {
                new Mamadi()
                {
                    Id = 1,
                    Title = "headr 1",
                    Created = "1399/09/01"
                },
                new Mamadi()
                {
                    Id = 2,
                    Title = "headr 2",
                    Created = "1399/09/02"
                },
                new Mamadi()
                {
                    Id = 3,
                    Title = "headr 3",
                    Created = "1399/09/03"
                },

            };
        }

        public IActionResult ViewerEvent()
        {

            return StiNetCoreViewer.ViewerEventResult(this);
        }

        public List<Base> GetDataBase()
        {
            return new List<Base>
            {
                new Base()
                {
                    Id= 1,
                    FirstName = "Ehsan",
                    LastName = "moridi",
                    Birthday = "2023/09/09 14:15"
                },
                new Base()
                {
                    Id= 2,
                    FirstName = "Ebi",
                    LastName = "mori",
                    Birthday = "2018/09/09 14:15"
                },
                new Base()
                {
                    Id= 2,
                    FirstName = "Ensaf",
                    LastName = "orii",
                    Birthday = "2020/09/09 14:15"
                }
            };
        }

    }
}
