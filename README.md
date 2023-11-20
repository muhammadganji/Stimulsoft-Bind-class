# Stimulsoft-binding property
Automation binding property of the class to report in `.net7` and `stimulsoft 2023`

- [linkdin author](https://linkedin.com/in/muhammad-ganji-nezhad)
- november 2023

![screen of program](https://github.com/muhammadganji/Stimulsoft-Bind-class/blob/master/Screenshot%202023-11-20%20131640.png)
<br/>Screen of program<br/>

## document of technical
in the `ViewerController` you can change model and data to create report.
this project depend on `ClassBinding` and `ClassReport`for bind class and data.
Example of code:
```c#
public IActionResult GetReport()
 {
   var data = GetDataMamadi();  // <--- change data binding
   var stimul = new StiReport();
   var jsonReport = GetFormatReport(new Mamadi());  // <--- change model binding
   stimul.LoadFromString(jsonReport);
   stimul.Compile();
   stimul.RegData("dt", data);
   return StiNetCoreViewer.GetReportResult(this, stimul);
 }
```

## ClassBinding
this class has duty to get feature of special class
- [ClassBinding.ca](https://github.com/muhammadganji/Stimulsoft-Bind-class/blob/master/Stimulsoft-Test/Models/BindClassToReport/ClassBinding.cs)

## ClassReport
this class has duty to create report of stimulsoft
- [ClassReport.cs](https://github.com/muhammadganji/Stimulsoft-Bind-class/blob/master/Stimulsoft-Test/Models/BindClassToReport/ClassReport.cs)
