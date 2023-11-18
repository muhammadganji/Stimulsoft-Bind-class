using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{
    public class Report : Stimulsoft.Report.StiReport
    {
        public Report()        {
            this.InitializeComponent();
        }

        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiHeaderBand Headerroot;
        public Stimulsoft.Report.Components.StiText Headerroot_Title;
        public Stimulsoft.Report.Components.StiDataBand Dataroot;
        public Stimulsoft.Report.Components.StiText Dataroot_Title;
        public rootDataSource root;
        
        public void Headerroot_Title__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Headerroot_Title
            e.Value = "Title";
        }
        
        public void Dataroot_Title__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Dataroot_Title
            e.Value = ToString(sender, root.Title, true);
        }
        
        public void CheckEndRenderRuntimes__EndRender(object sender, System.EventArgs e)
        {
            Stimulsoft.Report.Components.StiSimpleText.CheckEndRenderRuntimes(this);
        }
        
        private void InitializeComponent()
        {
            this.root = new rootDataSource();
            this.NeedsCompiling = false;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.Key = "92a318ce9d5a46b58078dc2ee0e2798c";
            this.ReferencedAssemblies = new string[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Report";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2023, 11, 18, 10, 24, 32, 762);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2023, 11, 18, 10, 18, 35, 0);
            this.ReportFile = "C:\\Users\\Saba Pc 4\\source\\repos\\Stimulsoft-Test\\Stimulsoft-Test\\Reports\\Report_General.mrt";
            this.ReportGuid = "504be567b4f347298a1b81ef9d606452";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ReportVersion = "2023.1.1.0";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "1f1c57ed72fb4f348efd0ee4b95cdd2b";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 11;
            this.Page1.PageWidth = 8.5;
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.Letter;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Headerroot
            // 
            this.Headerroot = new Stimulsoft.Report.Components.StiHeaderBand();
            this.Headerroot.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 7.72, 0.3);
            this.Headerroot.Name = "Headerroot";
            this.Headerroot.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Headerroot.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Headerroot_Title
            // 
            this.Headerroot_Title = new Stimulsoft.Report.Components.StiText();
            this.Headerroot_Title.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.7, 0.3);
            this.Headerroot_Title.Name = "Headerroot_Title";
            this.Headerroot_Title.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Headerroot_Title__GetValue);
            this.Headerroot_Title.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Headerroot_Title.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Headerroot_Title.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Headerroot_Title.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Headerroot_Title.Indicator = null;
            this.Headerroot_Title.Interaction = null;
            this.Headerroot_Title.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Headerroot_Title.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Headerroot_Title.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Headerroot.Interaction = null;
            // 
            // Dataroot
            // 
            this.Dataroot = new Stimulsoft.Report.Components.StiDataBand();
            this.Dataroot.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.9, 7.72, 0.3);
            this.Dataroot.DataSourceName = "root";
            this.Dataroot.Name = "Dataroot";
            this.Dataroot.Sort = new string[0];
            this.Dataroot.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Dataroot.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Dataroot.BusinessObjectGuid = null;
            // 
            // Dataroot_Title
            // 
            this.Dataroot_Title = new Stimulsoft.Report.Components.StiText();
            this.Dataroot_Title.CanGrow = true;
            this.Dataroot_Title.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.7, 0.3);
            this.Dataroot_Title.Name = "Dataroot_Title";
            this.Dataroot_Title.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Dataroot_Title__GetValue);
            this.Dataroot_Title.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Dataroot_Title.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Dataroot_Title.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Dataroot_Title.Font = new System.Drawing.Font("Arial", 8F);
            this.Dataroot_Title.Indicator = null;
            this.Dataroot_Title.Interaction = null;
            this.Dataroot_Title.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Dataroot_Title.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Dataroot_Title.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Dataroot.Interaction = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(0.39, 0.39, 0.39, 0.39);
            this.Page1.Report = this;
            this.Headerroot.Page = this.Page1;
            this.Headerroot.Parent = this.Page1;
            this.Headerroot_Title.Page = this.Page1;
            this.Headerroot_Title.Parent = this.Headerroot;
            this.Dataroot.Page = this.Page1;
            this.Dataroot.Parent = this.Page1;
            this.Dataroot_Title.Page = this.Page1;
            this.Dataroot_Title.Parent = this.Dataroot;
            this.EndRender += new System.EventHandler(this.CheckEndRenderRuntimes__EndRender);
            // 
            // Add to Headerroot.Components
            // 
            this.Headerroot.Components.Clear();
            this.Headerroot.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Headerroot_Title});
            // 
            // Add to Dataroot.Components
            // 
            this.Dataroot.Components.Clear();
            this.Dataroot.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Dataroot_Title});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Headerroot,
                        this.Dataroot});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            this.root.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string), null)});
            this.DataSources.Add(this.root);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiJsonDatabase("dt", "C:\\Users\\Saba Pc 4\\Desktop\\json test stimulsoft.json", "34f727113499428892587e5217f597c5"));
        }
        
        // CheckerInfo: *None* *DataSources*
        #region DataSource root
        public class rootDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public rootDataSource() : 
                    base("dt", "root", "root", "4aa0affe42a5435da994afb21d1d4ac1")
            {
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource root
        #endregion StiReport Designer generated code - do not modify
    }
}
