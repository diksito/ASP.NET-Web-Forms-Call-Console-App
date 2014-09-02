using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void CallConsole_Click(object sender, EventArgs e)
        {
            string action = actionList.SelectedValue.ToString();
            double x = 0.0;
            double y = 0.0;
            double.TryParse(aValue.Text, out x);
            double.TryParse(bValue.Text, out y);

            Process process = new Process();
            process.StartInfo.FileName = @"C:\Users\Nikolay\Desktop\ASP NET and Console App\ConsoleApp\bin\Debug\ConsoleApp.exe";
            process.StartInfo.Arguments = action + " " + x + " " + y;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
            string output = string.Empty;
            output = process.StandardOutput.ReadToEnd(); // call this if you want to get the full output

            labelConsoleOutput.Text = output; // print console output
        }
    }
}