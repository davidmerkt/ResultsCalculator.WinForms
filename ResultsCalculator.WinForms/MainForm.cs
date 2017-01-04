using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsCalculator.WinForms
{
    public partial class MainForm : Form
    {
        Runner newRunner;

        public MainForm()
        {
            InitializeComponent();
            resultsBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            newRunner = new Runner() { Name = runnerName.Text, StartTime = startTime.Value, EndTime = finishTime.Value, TotalLaps = Convert.ToInt16(lapsCount.Value) };
            resultsBox.Text = newRunner.Name + Environment.NewLine + newRunner.TotalLaps + Environment.NewLine + newRunner.TotalTime.ToString();
            resultsBox.Visible = true;
        }
    }
}
