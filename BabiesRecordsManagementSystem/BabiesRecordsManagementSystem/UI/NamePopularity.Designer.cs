namespace BabiesRecordsManagementSystem.UI
{
    partial class NamePopularity
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtYearTo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFromYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnBabyRanking = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.Location = new System.Drawing.Point(12, 102);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Year";
            series5.YValuesPerPoint = 4;
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(680, 352);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chartPopularity";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtYearTo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtFromYear);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdGender);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnBabyRanking);
            this.panel1.Location = new System.Drawing.Point(15, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 84);
            this.panel1.TabIndex = 11;
            // 
            // txtYearTo
            // 
            this.txtYearTo.Location = new System.Drawing.Point(366, 37);
            this.txtYearTo.MaxLength = 4;
            this.txtYearTo.Name = "txtYearTo";
            this.txtYearTo.Size = new System.Drawing.Size(60, 20);
            this.txtYearTo.TabIndex = 3;
            this.txtYearTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearTo_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(315, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year To";
            // 
            // txtFromYear
            // 
            this.txtFromYear.Location = new System.Drawing.Point(254, 38);
            this.txtFromYear.MaxLength = 4;
            this.txtFromYear.Name = "txtFromYear";
            this.txtFromYear.Size = new System.Drawing.Size(55, 20);
            this.txtFromYear.TabIndex = 2;
            this.txtFromYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFromYear_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Year From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Gender";
            // 
            // cmdGender
            // 
            this.cmdGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmdGender.FormattingEnabled = true;
            this.cmdGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmdGender.Location = new System.Drawing.Point(480, 38);
            this.cmdGender.Name = "cmdGender";
            this.cmdGender.Size = new System.Drawing.Size(70, 21);
            this.cmdGender.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(138, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnBabyRanking
            // 
            this.btnBabyRanking.Location = new System.Drawing.Point(556, 38);
            this.btnBabyRanking.Name = "btnBabyRanking";
            this.btnBabyRanking.Size = new System.Drawing.Size(110, 23);
            this.btnBabyRanking.TabIndex = 11;
            this.btnBabyRanking.Text = "Filter";
            this.btnBabyRanking.UseVisualStyleBackColor = true;
            this.btnBabyRanking.Click += new System.EventHandler(this.btnBabyRanking_Click_1);
            // 
            // NamePopularity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NamePopularity";
            this.Text = "Name Popularity";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtYearTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFromYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnBabyRanking;

    }
}