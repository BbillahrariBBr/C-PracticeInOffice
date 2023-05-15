using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRPrac.Reports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace CRPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportShowForm reportShowForm = new ReportShowForm();
            RecordShowWithOutDB report = new RecordShowWithOutDB();

            TextObject first = (TextObject)report.ReportDefinition.Sections["Section3"].ReportObjects["FirstNameText"];
            first.Text = tbxFirstName.Text;
            TextObject last = (TextObject)report.ReportDefinition.Sections["Section3"].ReportObjects["LastNameText"];
            last.Text = tbxLastName.Text;
            TextObject user = (TextObject)report.ReportDefinition.Sections["Section3"].ReportObjects["UserNameText"];
            user.Text = tbxUserName.Text;
            TextObject pass = (TextObject)report.ReportDefinition.Sections["Section3"].ReportObjects["PasswordText"];
            pass.Text = tbxPassword.Text;

            reportShowForm.crystalReportViewer1.ReportSource = report;
            reportShowForm.Show();
        }
    }
}
