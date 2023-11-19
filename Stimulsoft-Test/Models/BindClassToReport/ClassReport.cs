namespace Stimulsoft_Test.Models.BindClassToReport;

public class ClassReport
{
    /// <summary>
    /// بایند مدل در جیسون
    /// </summary>
    /// <param name="results">استراکچر مدل</param>
    /// <returns>جیسون فایل استیمول سافت</returns>
    public string GetAll(List<Result> results)
    {
        var result = @"{
  'ReportVersion': '2023.1.1.0',
  'ReportGuid': 'e436a74174d44dd2b6b9c627c07622d1',
  'ReportName': 'Report',
  'ReportAlias': 'Report',
  'ReportCreated': '/Date(1700290115000+0330)/',
  'ReportChanged': '/Date(1700295989252+0330)/',
  'EngineVersion': 'EngineV2',
  'ReportUnit': 'Inches',
  'Script': 'using System;\r\nusing System.Drawing;\r\nusing System.Windows.Forms;\r\nusing System.Data;\r\nusing Stimulsoft.Controls;\r\nusing Stimulsoft.Base.Drawing;\r\nusing Stimulsoft.Report;\r\nusing Stimulsoft.Report.Dialogs;\r\nusing Stimulsoft.Report.Components;\r\n\r\nnamespace Reports\r\n{\r\n    public class Report : Stimulsoft.Report.StiReport\r\n    {\r\n        public Report()        {\r\n            this.InitializeComponent();\r\n        }\r\n\r\n        #region StiReport Designer generated code - do not modify\r\n\t\t#endregion StiReport Designer generated code - do not modify\r\n    }\r\n}\r\n',
  'ReferencedAssemblies': {
    '0': 'System.Dll',
    '1': 'System.Drawing.Dll',
    '2': 'System.Windows.Forms.Dll',
    '3': 'System.Data.Dll',
    '4': 'System.Xml.Dll',
    '5': 'Stimulsoft.Controls.Dll',
    '6': 'Stimulsoft.Base.Dll',
    '7': 'Stimulsoft.Report.Dll'
  },
  'Dictionary': {
    'DataSources': {
      '0': {
        'Ident': 'StiDataTableSource',
        'Name': 'root',
        'Alias': 'root',
        'Key': '0aa1eec61ae04b4b8f8e8182c444e5a9',
        'Columns': {
          "
        + this.GetColumns(results) +
    @"
        },
        'NameInSource': 'dt'
      }
    }
  },
  'Pages': {
    '0': {
      'Ident': 'StiPage',
      'Name': 'Page1',
      'Guid': '1f1c57ed72fb4f348efd0ee4b95cdd2b',
      'Interaction': {
        'Ident': 'StiInteraction'
      },
      'Border': ';;2;;;;;solid:Black',
      'Brush': 'solid:',
      'Components': {
        '0': {
          'Ident': 'StiHeaderBand',
          'Name': 'Headerroot',
          'ClientRectangle': '0,0.2,7.72,0.3',
          'Interaction': {
            'Ident': 'StiInteraction'
          },
          'Border': ';;;;;;;solid:Black',
          'Brush': 'solid:',
          'Components': {
"

     + this.GetComponents(results) +

    @"
          }
        },
        '1': {
          'Ident': 'StiDataBand',
          'Name': 'Dataroot',
          'ClientRectangle': '0,0.9,7.72,0.3',
          'Interaction': {
            'Ident': 'StiBandInteraction'
          },
          'Border': ';;;;;;;solid:Black',
          'Brush': 'solid:',
          'Components': { 
                "

    + this.GetComponentsData(results) +

    @"    }
          },
          'DataSourceName': 'root'
        }
      },
      'PaperSize': 'Letter',
      'PageWidth': 8.5,
      'PageHeight': 11.0,
      'Watermark': {
        'TextBrush': 'solid:50,0,0,0'
      },
      'Margins': {
        'Left': 0.39,
        'Right': 0.39,
        'Top': 0.39,
        'Bottom': 0.39
      }
    }
  }";

        result = result.Replace("'", "\"");
        result = result.Replace("\"\"", "\"");
        //result = result.Replace("}\"", "}");
        return result;

    }

    /// <summary>
    /// مدل
    /// </summary>
    private string GetColumns(List<Result> results)
    {
        string cols = "";
        for (int i = 0; i < results.Count; i++)
        {
            var temp = $"'{i}':" +
                "{" +
                $"'Name': '{results[i].Property}', 'Index': -1, 'NameInSource': '{results[i].Property}', 'Alias': '{results[i].Description}', 'Type': 'System.String'" +
                "}";
            if (i < (results.Count - 1)) temp += ", ";

            cols += temp;
        }
        return cols;
    }

    /// <summary>
    /// عنوان جدول
    /// </summary>
    /// <param name="results">مدل</param>
    /// <returns>header of table</returns>
    private string GetComponents(List<Result> results)
    {
        string comps = "";

        for (int i = 0; i < results.Count; i++)
        {
            string temp = $"'{i}' :" + " { ";
            temp += "'Ident': 'StiText', ";
            temp += $"'Name': 'Headerroot_{results[i].Property}__{results[i].Description}_' ,";
            temp += $"'ClientRectangle' : {GetClientRectangle(i, results.Count)},";
            temp += "'Interaction': { 'Ident': 'StiInteraction' }, 'Text': { ";
            temp += $"'Value': '{results[i].Description}'";
            temp += @""" },
                'VertAlignment': 'Center',
              'Font': ';10;Bold;',
              'Border': ';;;;;;;solid:Black',
              'Brush': 'solid:',
              'TextBrush': 'solid:Black',
              'TextOptions': {
                'WordWrap': true
                }
               }""";
            if (i < (results.Count - 1)) temp += ", ";

            comps += temp;
        }

        return comps.Replace("\"","");
    }

    /// <summary>
    /// ترسیم موقعیت عنوان
    /// </summary>
    /// <param name="index">چندمین مدل</param>
    /// <param name="columns">تعداد ستون های مدل</param>
    /// <param name="total">ابعاد برگه به اینچ</param>
    /// <returns>'5.7	,0	,2	    ,0.3'</returns>
    private string GetClientRectangle(int index, int columns, int total = 8)
    {

        /*
         "ClientRectangle": "0		,0	,1.9	,0.3",
         "ClientRectangle": "1.9	,0	,1.9	,0.3",
         "ClientRectangle": "3.8	,0	,1.9	,0.3",
         "ClientRectangle": "5.7	,0	,2	    ,0.3",

        columns: 4 		unit: 1.9
         */
        double result = (double)total / columns;  // تبدیل total به نوع double برای دقت بیشتر در تقسیم
        double unit = Math.Round(result, 1, MidpointRounding.ToEven);
        return $"'{((double)index * unit)},0,{unit},0.3'";



    }

    /// <summary>
    /// سطرهای جدول
    /// </summary>
    /// <param name="results">مدل</param>
    /// <returns>rows of table</returns>
    private string GetComponentsData(List<Result> results)
    {
        string comps = "";

        for (int i = 0; i < results.Count; i++)
        {
            string temp = "";
            temp += $"'{i}':" + " { 'Ident': 'StiText'," +
                $"'Name': 'Dataroot_{results[i].Property}__{results[i].Description}_', " +
                $"'CanGrow': true," +
                $"'ClientRectangle': {this.GetClientRectangle(i, results.Count)}," +
                "'Interaction': { 'Ident': 'StiInteraction' }, 'Text': { 'Value': '{" +
                $"root.{results[i].Property}" + "}' }, 'VertAlignment': 'Center', " +
                "'Border': ';;;;;;;solid:Black'," +
                "'Brush': 'solid:'," +
                "'TextBrush': 'solid:Black'," +
                "'TextOptions': {" +
                "'WordWrap': true } }";

            if (i < (results.Count - 1)) { temp += ", "; }

            comps += temp;
        }

        return comps.Replace("\"", "");
    }

}




