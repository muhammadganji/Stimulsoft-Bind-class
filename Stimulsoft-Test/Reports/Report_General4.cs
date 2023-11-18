using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports4
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
        public Stimulsoft.Report.Components.StiText Headerroot_TypeExam;
        public Stimulsoft.Report.Components.StiText Headerroot_DateCreated;
        public Stimulsoft.Report.Components.StiText Headerroot_Score;
        public Stimulsoft.Report.Components.StiDataBand Dataroot;
        public Stimulsoft.Report.Components.StiText Dataroot_Title;
        public Stimulsoft.Report.Components.StiText Dataroot_TypeExam;
        public Stimulsoft.Report.Components.StiText Dataroot_DateCreated;
        public Stimulsoft.Report.Components.StiText Dataroot_Score;
        public rootDataSource root;
        
        public void Headerroot_Title__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Headerroot_Title
            e.Value = "Title";
        }
        
        public void Headerroot_TypeExam__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Headerroot_TypeExam
            e.Value = "TypeExam";
        }
        
        public void Headerroot_DateCreated__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Headerroot_DateCreated
            e.Value = "DateCreated";
        }
        
        public void Headerroot_Score__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Headerroot_Score
            e.Value = "Score";
        }
        
        public void Dataroot_Title__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Dataroot_Title
            e.Value = ToString(sender, root.Title, true);
        }
        
        public void Dataroot_TypeExam__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Dataroot_TypeExam
            e.Value = ToString(sender, root.TypeExam, true);
        }
        
        public void Dataroot_DateCreated__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Dataroot_DateCreated
            e.Value = ToString(sender, root.DateCreated, true);
        }
        
        public void Dataroot_Score__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            // CheckerInfo: Text Dataroot_Score
            e.Value = ToString(sender, root.Score, true);
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
            this.ReportChanged = new DateTime(2023, 11, 18, 10, 27, 58, 739);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2023, 11, 18, 10, 18, 35, 0);
            this.ReportFile = "C:\\Users\\Saba Pc 4\\source\\repos\\Stimulsoft-Test\\Stimulsoft-Test\\Reports\\Report_General.mrt";
            this.ReportGuid = "f5ce77e6987c4fbfb1f9765d01eeb916";
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
            this.Headerroot_Title.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 1.9, 0.3);
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
            // 
            // Headerroot_TypeExam
            // 
            this.Headerroot_TypeExam = new Stimulsoft.Report.Components.StiText();
            this.Headerroot_TypeExam.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.9, 0, 1.9, 0.3);
            this.Headerroot_TypeExam.Name = "Headerroot_TypeExam";
            this.Headerroot_TypeExam.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Headerroot_TypeExam__GetValue);
            this.Headerroot_TypeExam.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Headerroot_TypeExam.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Headerroot_TypeExam.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Headerroot_TypeExam.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Headerroot_TypeExam.Indicator = null;
            this.Headerroot_TypeExam.Interaction = null;
            this.Headerroot_TypeExam.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Headerroot_TypeExam.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Headerroot_TypeExam.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Headerroot_DateCreated
            // 
            this.Headerroot_DateCreated = new Stimulsoft.Report.Components.StiText();
            this.Headerroot_DateCreated.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 0, 1.9, 0.3);
            this.Headerroot_DateCreated.Name = "Headerroot_DateCreated";
            this.Headerroot_DateCreated.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Headerroot_DateCreated__GetValue);
            this.Headerroot_DateCreated.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Headerroot_DateCreated.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Headerroot_DateCreated.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Headerroot_DateCreated.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Headerroot_DateCreated.Indicator = null;
            this.Headerroot_DateCreated.Interaction = null;
            this.Headerroot_DateCreated.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Headerroot_DateCreated.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Headerroot_DateCreated.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Headerroot_Score
            // 
            this.Headerroot_Score = new Stimulsoft.Report.Components.StiText();
            this.Headerroot_Score.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.7, 0, 2, 0.3);
            this.Headerroot_Score.Name = "Headerroot_Score";
            this.Headerroot_Score.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Headerroot_Score__GetValue);
            this.Headerroot_Score.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Headerroot_Score.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Headerroot_Score.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Headerroot_Score.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Headerroot_Score.Indicator = null;
            this.Headerroot_Score.Interaction = null;
            this.Headerroot_Score.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Headerroot_Score.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Headerroot_Score.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
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
            this.Dataroot_Title.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 1.9, 0.3);
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
            // 
            // Dataroot_TypeExam
            // 
            this.Dataroot_TypeExam = new Stimulsoft.Report.Components.StiText();
            this.Dataroot_TypeExam.CanGrow = true;
            this.Dataroot_TypeExam.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(1.9, 0, 1.9, 0.3);
            this.Dataroot_TypeExam.Name = "Dataroot_TypeExam";
            this.Dataroot_TypeExam.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Dataroot_TypeExam__GetValue);
            this.Dataroot_TypeExam.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Dataroot_TypeExam.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Dataroot_TypeExam.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Dataroot_TypeExam.Font = new System.Drawing.Font("Arial", 8F);
            this.Dataroot_TypeExam.Indicator = null;
            this.Dataroot_TypeExam.Interaction = null;
            this.Dataroot_TypeExam.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Dataroot_TypeExam.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Dataroot_TypeExam.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Dataroot_DateCreated
            // 
            this.Dataroot_DateCreated = new Stimulsoft.Report.Components.StiText();
            this.Dataroot_DateCreated.CanGrow = true;
            this.Dataroot_DateCreated.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.8, 0, 1.9, 0.3);
            this.Dataroot_DateCreated.Name = "Dataroot_DateCreated";
            this.Dataroot_DateCreated.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Dataroot_DateCreated__GetValue);
            this.Dataroot_DateCreated.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Dataroot_DateCreated.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Dataroot_DateCreated.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Dataroot_DateCreated.Font = new System.Drawing.Font("Arial", 8F);
            this.Dataroot_DateCreated.Indicator = null;
            this.Dataroot_DateCreated.Interaction = null;
            this.Dataroot_DateCreated.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Dataroot_DateCreated.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Dataroot_DateCreated.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Dataroot_Score
            // 
            this.Dataroot_Score = new Stimulsoft.Report.Components.StiText();
            this.Dataroot_Score.CanGrow = true;
            this.Dataroot_Score.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.7, 0, 2, 0.3);
            this.Dataroot_Score.Name = "Dataroot_Score";
            this.Dataroot_Score.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Dataroot_Score__GetValue);
            this.Dataroot_Score.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Dataroot_Score.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Dataroot_Score.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Dataroot_Score.Font = new System.Drawing.Font("Arial", 8F);
            this.Dataroot_Score.Indicator = null;
            this.Dataroot_Score.Interaction = null;
            this.Dataroot_Score.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Dataroot_Score.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Dataroot_Score.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Dataroot.Interaction = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(0.39, 0.39, 0.39, 0.39);
            this.Page1.Report = this;
            this.Headerroot.Page = this.Page1;
            this.Headerroot.Parent = this.Page1;
            this.Headerroot_Title.Page = this.Page1;
            this.Headerroot_Title.Parent = this.Headerroot;
            this.Headerroot_TypeExam.Page = this.Page1;
            this.Headerroot_TypeExam.Parent = this.Headerroot;
            this.Headerroot_DateCreated.Page = this.Page1;
            this.Headerroot_DateCreated.Parent = this.Headerroot;
            this.Headerroot_Score.Page = this.Page1;
            this.Headerroot_Score.Parent = this.Headerroot;
            this.Dataroot.Page = this.Page1;
            this.Dataroot.Parent = this.Page1;
            this.Dataroot_Title.Page = this.Page1;
            this.Dataroot_Title.Parent = this.Dataroot;
            this.Dataroot_TypeExam.Page = this.Page1;
            this.Dataroot_TypeExam.Parent = this.Dataroot;
            this.Dataroot_DateCreated.Page = this.Page1;
            this.Dataroot_DateCreated.Parent = this.Dataroot;
            this.Dataroot_Score.Page = this.Page1;
            this.Dataroot_Score.Parent = this.Dataroot;
            this.EndRender += new System.EventHandler(this.CheckEndRenderRuntimes__EndRender);
            // 
            // Add to Headerroot.Components
            // 
            this.Headerroot.Components.Clear();
            this.Headerroot.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Headerroot_Title,
                        this.Headerroot_TypeExam,
                        this.Headerroot_DateCreated,
                        this.Headerroot_Score});
            // 
            // Add to Dataroot.Components
            // 
            this.Dataroot.Components.Clear();
            this.Dataroot.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Dataroot_Title,
                        this.Dataroot_TypeExam,
                        this.Dataroot_DateCreated,
                        this.Dataroot_Score});
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
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Title", "Title", "Title", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("TypeExam", "TypeExam", "TypeExam", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("DateCreated", "DateCreated", "DateCreated", typeof(string), null),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Score", "Score", "Score", typeof(string), null)});
            this.DataSources.Add(this.root);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiJsonDatabase("dt", "C:\\Users\\Saba Pc 4\\Desktop\\json test stimulsoft.json", "c472b8f657804ef0bf6d340560342bed"));
        }
        
        // CheckerInfo: *None* *DataSources*
        #region DataSource root
        public class rootDataSource : Stimulsoft.Report.Dictionary.StiDataTableSource
        {
            
            public rootDataSource() : 
                    base("dt", "root", "root", "0aa1eec61ae04b4b8f8e8182c444e5a9")
            {
            }
            
            public virtual string Title
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Title"], typeof(string), true)));
                }
            }
            
            public virtual string TypeExam
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["TypeExam"], typeof(string), true)));
                }
            }
            
            public virtual string DateCreated
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["DateCreated"], typeof(string), true)));
                }
            }
            
            public virtual string Score
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Score"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource root
        #endregion StiReport Designer generated code - do not modify
    }
}
