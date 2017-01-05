namespace ResultsCalculator.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.runnerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.finishTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lapsCount = new System.Windows.Forms.NumericUpDown();
            this.calculate = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.resultsBox = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.addRunner = new System.Windows.Forms.Button();
            this.deleteRunner = new System.Windows.Forms.Button();
            this.export = new System.Windows.Forms.Button();
            this.raceStartTime = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lapsCount)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Runner Name";
            // 
            // runnerName
            // 
            this.runnerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.runnerName.Location = new System.Drawing.Point(91, 12);
            this.runnerName.Name = "runnerName";
            this.runnerName.Size = new System.Drawing.Size(521, 20);
            this.runnerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Start Time";
            // 
            // startTime
            // 
            this.startTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.startTime.CustomFormat = "h:mm tt";
            this.startTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startTime.Location = new System.Drawing.Point(91, 38);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(521, 20);
            this.startTime.TabIndex = 3;
            this.startTime.Value = new System.DateTime(2017, 1, 1, 8, 0, 0, 0);
            // 
            // finishTime
            // 
            this.finishTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.finishTime.CustomFormat = "h:mm tt";
            this.finishTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.finishTime.Location = new System.Drawing.Point(91, 64);
            this.finishTime.Name = "finishTime";
            this.finishTime.Size = new System.Drawing.Size(521, 20);
            this.finishTime.TabIndex = 4;
            this.finishTime.Value = new System.DateTime(2017, 1, 1, 8, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Finish Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Number of Laps";
            // 
            // lapsCount
            // 
            this.lapsCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lapsCount.Location = new System.Drawing.Point(91, 90);
            this.lapsCount.Name = "lapsCount";
            this.lapsCount.Size = new System.Drawing.Size(521, 20);
            this.lapsCount.TabIndex = 7;
            this.lapsCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(12, 116);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // resultsBox
            // 
            this.resultsBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsBox.Location = new System.Drawing.Point(12, 145);
            this.resultsBox.Multiline = true;
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.ReadOnly = true;
            this.resultsBox.Size = new System.Drawing.Size(600, 52);
            this.resultsBox.TabIndex = 9;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(600, 199);
            this.listBox1.TabIndex = 10;
            // 
            // addRunner
            // 
            this.addRunner.Location = new System.Drawing.Point(90, 116);
            this.addRunner.Name = "addRunner";
            this.addRunner.Size = new System.Drawing.Size(75, 23);
            this.addRunner.TabIndex = 11;
            this.addRunner.Text = "Add Runner";
            this.addRunner.UseVisualStyleBackColor = true;
            this.addRunner.Click += new System.EventHandler(this.addRunner_Click);
            // 
            // deleteRunner
            // 
            this.deleteRunner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteRunner.Enabled = false;
            this.deleteRunner.Location = new System.Drawing.Point(12, 408);
            this.deleteRunner.Name = "deleteRunner";
            this.deleteRunner.Size = new System.Drawing.Size(75, 23);
            this.deleteRunner.TabIndex = 12;
            this.deleteRunner.Text = "Delete";
            this.deleteRunner.UseVisualStyleBackColor = true;
            this.deleteRunner.Click += new System.EventHandler(this.deleteRunner_Click);
            // 
            // export
            // 
            this.export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.export.Location = new System.Drawing.Point(93, 408);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 13;
            this.export.Text = "Export CSV";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // raceStartTime
            // 
            this.raceStartTime.CustomFormat = "h:mm tt";
            this.raceStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.raceStartTime.Location = new System.Drawing.Point(279, 118);
            this.raceStartTime.Name = "raceStartTime";
            this.raceStartTime.Size = new System.Drawing.Size(85, 20);
            this.raceStartTime.TabIndex = 14;
            this.raceStartTime.Value = new System.DateTime(2017, 1, 1, 8, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Race Start Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.addRunner;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.raceStartTime);
            this.Controls.Add(this.export);
            this.Controls.Add(this.deleteRunner);
            this.Controls.Add(this.addRunner);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.lapsCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.finishTime);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.runnerName);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "MainForm";
            this.Text = "Results Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.lapsCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox runnerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.DateTimePicker finishTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown lapsCount;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox resultsBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button addRunner;
        private System.Windows.Forms.Button deleteRunner;
        private System.Windows.Forms.Button export;
        private System.Windows.Forms.DateTimePicker raceStartTime;
        private System.Windows.Forms.Button button1;
    }
}

