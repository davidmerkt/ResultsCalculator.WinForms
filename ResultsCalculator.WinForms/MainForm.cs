using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResultsCalculator.WinForms
{
    public partial class MainForm : Form
    {
        Runner newRunner;

        List<Runner> runnerList = new List<Runner>();

        public MainForm()
        {
            InitializeComponent();
            resultsBox.Visible = false;
            //startTime.Value = 
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            newRunner = new Runner() { Name = runnerName.Text, StartTime = startTime.Value, EndTime = finishTime.Value, TotalLaps = Convert.ToInt16(lapsCount.Value) };
            resultsBox.Text = newRunner.Name + Environment.NewLine + newRunner.TotalLaps + Environment.NewLine + newRunner.TotalTime.ToString();
            resultsBox.Visible = true;
        }

        private void addRunner_Click(object sender, EventArgs e)
        {
            runnerList.Add(new Runner() { Name = runnerName.Text, StartTime = startTime.Value, EndTime = finishTime.Value, TotalLaps = Convert.ToInt16(lapsCount.Value) });
            runnerList.Sort();

            listBox1.Items.Clear();

            listBox1.Items.Add("Name\tLaps\tTime");

            for (int i = 0; i < runnerList.Count; i++)
                listBox1.Items.Add(runnerList[i].Name.ToString() + "\t" + runnerList[i].TotalLaps.ToString() + "\t" + runnerList[i].TotalTime.ToString());
            //listBox1.Items.Add(runnerList[runnerList.Count - 1].Name.ToString() + "\t" + runnerList[runnerList.Count - 1].TotalLaps.ToString() + "\t" + runnerList[runnerList.Count - 1].TotalTime.ToString());

            deleteRunner.Enabled = true;
        }

        private void deleteRunner_Click(object sender, EventArgs e)
        {
            int selectedRow;

            selectedRow = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(selectedRow);
            runnerList.RemoveAt(selectedRow - 1);
        }

        private void export_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\runnerlist.csv";
            try
            {
                StreamWriter sw = new StreamWriter(path);

                sw.WriteLine("Name,Laps,Time");

                for (int i = 0; i < runnerList.Count; i++)
                {
                    sw.WriteLine(runnerList[i].Name + "," + runnerList[i].TotalLaps + "," + runnerList[i].TotalTime.ToString());
                }

                sw.Close();
                MessageBox.Show("CSV Results exported to:\n" + path, "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Export failed to:\n" + path, "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startTime.Value = raceStartTime.Value;
        }
    }
}
