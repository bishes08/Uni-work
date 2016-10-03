namespace StudentMark
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textAggregatedMark = new System.Windows.Forms.TextBox();
            this.textFinalExam = new System.Windows.Forms.TextBox();
            this.textCoursework2 = new System.Windows.Forms.TextBox();
            this.textCoursework1 = new System.Windows.Forms.TextBox();
            this.textEmailAddress = new System.Windows.Forms.TextBox();
            this.textSurName = new System.Windows.Forms.TextBox();
            this.textForeName = new System.Windows.Forms.TextBox();
            this.textStudentID = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.radioButtonAlphabetical = new System.Windows.Forms.RadioButton();
            this.radioButtonNumeric = new System.Windows.Forms.RadioButton();
            this.buttonImport = new System.Windows.Forms.Button();
            this.textClassAverage = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonRetreive = new System.Windows.Forms.Button();
            this.buttonAggregatedMarkSort = new System.Windows.Forms.Button();
            this.buttonSurnameSort = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonVerify = new System.Windows.Forms.Button();
            this.responce = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.responce);
            this.groupBox4.Controls.Add(this.buttonVerify);
            this.groupBox4.Controls.Add(this.buttonAdd);
            this.groupBox4.Controls.Add(this.textAggregatedMark);
            this.groupBox4.Controls.Add(this.textFinalExam);
            this.groupBox4.Controls.Add(this.textCoursework2);
            this.groupBox4.Controls.Add(this.textCoursework1);
            this.groupBox4.Controls.Add(this.textEmailAddress);
            this.groupBox4.Controls.Add(this.textSurName);
            this.groupBox4.Controls.Add(this.textForeName);
            this.groupBox4.Controls.Add(this.textStudentID);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.Controls.Add(this.label23);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Location = new System.Drawing.Point(332, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(556, 296);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Details Input";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(319, 242);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(132, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add/Update";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textAggregatedMark
            // 
            this.textAggregatedMark.Location = new System.Drawing.Point(402, 169);
            this.textAggregatedMark.Name = "textAggregatedMark";
            this.textAggregatedMark.ReadOnly = true;
            this.textAggregatedMark.Size = new System.Drawing.Size(49, 20);
            this.textAggregatedMark.TabIndex = 15;
            // 
            // textFinalExam
            // 
            this.textFinalExam.Location = new System.Drawing.Point(402, 124);
            this.textFinalExam.Name = "textFinalExam";
            this.textFinalExam.Size = new System.Drawing.Size(49, 20);
            this.textFinalExam.TabIndex = 14;
            this.textFinalExam.Validating += new System.ComponentModel.CancelEventHandler(this.textFinalExam_Validating);
            this.textFinalExam.Validated += new System.EventHandler(this.textFinalExam_Validated);
            // 
            // textCoursework2
            // 
            this.textCoursework2.Location = new System.Drawing.Point(402, 87);
            this.textCoursework2.Name = "textCoursework2";
            this.textCoursework2.Size = new System.Drawing.Size(49, 20);
            this.textCoursework2.TabIndex = 13;
            this.textCoursework2.Validating += new System.ComponentModel.CancelEventHandler(this.textCoursework2_Validating);
            this.textCoursework2.Validated += new System.EventHandler(this.textCoursework2_Validated);
            // 
            // textCoursework1
            // 
            this.textCoursework1.Location = new System.Drawing.Point(402, 47);
            this.textCoursework1.Name = "textCoursework1";
            this.textCoursework1.Size = new System.Drawing.Size(49, 20);
            this.textCoursework1.TabIndex = 12;
            this.textCoursework1.Validating += new System.ComponentModel.CancelEventHandler(this.textCoursework1_Validating_1);
            this.textCoursework1.Validated += new System.EventHandler(this.textCoursework1_Validated);
            // 
            // textEmailAddress
            // 
            this.textEmailAddress.Location = new System.Drawing.Point(86, 188);
            this.textEmailAddress.Name = "textEmailAddress";
            this.textEmailAddress.Size = new System.Drawing.Size(110, 20);
            this.textEmailAddress.TabIndex = 11;
            // 
            // textSurName
            // 
            this.textSurName.Location = new System.Drawing.Point(86, 142);
            this.textSurName.Name = "textSurName";
            this.textSurName.Size = new System.Drawing.Size(110, 20);
            this.textSurName.TabIndex = 10;
            this.textSurName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textSurName_KeyPress);
            // 
            // textForeName
            // 
            this.textForeName.Location = new System.Drawing.Point(86, 91);
            this.textForeName.Name = "textForeName";
            this.textForeName.Size = new System.Drawing.Size(110, 20);
            this.textForeName.TabIndex = 9;
            this.textForeName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textForeName_KeyPress);
            // 
            // textStudentID
            // 
            this.textStudentID.Location = new System.Drawing.Point(86, 47);
            this.textStudentID.Name = "textStudentID";
            this.textStudentID.Size = new System.Drawing.Size(110, 20);
            this.textStudentID.TabIndex = 8;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(309, 172);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(91, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "Aggregated mark:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(309, 128);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(60, 13);
            this.label23.TabIndex = 6;
            this.label23.Text = "Final exam:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(309, 90);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(75, 13);
            this.label24.TabIndex = 5;
            this.label24.Text = "Coursework 2:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(309, 50);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(75, 13);
            this.label25.TabIndex = 4;
            this.label25.Text = "Coursework 1:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(27, 191);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "Email:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(27, 146);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 2;
            this.label20.Text = "Surname:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(27, 94);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(57, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Forename:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(27, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(61, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Student ID:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.radioButtonAlphabetical);
            this.groupBox5.Controls.Add(this.radioButtonNumeric);
            this.groupBox5.Controls.Add(this.buttonImport);
            this.groupBox5.Controls.Add(this.textClassAverage);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.listBox3);
            this.groupBox5.Controls.Add(this.chart3);
            this.groupBox5.Location = new System.Drawing.Point(15, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(311, 362);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "GraphBox";
            // 
            // radioButtonAlphabetical
            // 
            this.radioButtonAlphabetical.AutoSize = true;
            this.radioButtonAlphabetical.Location = new System.Drawing.Point(168, 271);
            this.radioButtonAlphabetical.Name = "radioButtonAlphabetical";
            this.radioButtonAlphabetical.Size = new System.Drawing.Size(83, 17);
            this.radioButtonAlphabetical.TabIndex = 19;
            this.radioButtonAlphabetical.TabStop = true;
            this.radioButtonAlphabetical.Text = "Alphabetical";
            this.radioButtonAlphabetical.UseVisualStyleBackColor = true;
            // 
            // radioButtonNumeric
            // 
            this.radioButtonNumeric.AutoSize = true;
            this.radioButtonNumeric.Location = new System.Drawing.Point(168, 248);
            this.radioButtonNumeric.Name = "radioButtonNumeric";
            this.radioButtonNumeric.Size = new System.Drawing.Size(64, 17);
            this.radioButtonNumeric.TabIndex = 18;
            this.radioButtonNumeric.TabStop = true;
            this.radioButtonNumeric.Text = "Numeric";
            this.radioButtonNumeric.UseVisualStyleBackColor = true;
            this.radioButtonNumeric.CheckedChanged += new System.EventHandler(this.radioButtonNumeric_CheckedChanged_1);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(10, 317);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(103, 27);
            this.buttonImport.TabIndex = 17;
            this.buttonImport.Text = "Import CSV file";
            this.buttonImport.UseVisualStyleBackColor = true;
            // 
            // textClassAverage
            // 
            this.textClassAverage.Location = new System.Drawing.Point(251, 206);
            this.textClassAverage.Name = "textClassAverage";
            this.textClassAverage.ReadOnly = true;
            this.textClassAverage.Size = new System.Drawing.Size(49, 20);
            this.textClassAverage.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(168, 209);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(77, 13);
            this.label26.TabIndex = 16;
            this.label26.Text = "Class average:";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 202);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(156, 108);
            this.listBox3.TabIndex = 1;
            // 
            // chart3
            // 
            chartArea1.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart3.Legends.Add(legend1);
            this.chart3.Location = new System.Drawing.Point(10, 19);
            this.chart3.Name = "chart3";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(295, 170);
            this.chart3.TabIndex = 0;
            this.chart3.Text = "chart3";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(21, 380);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(871, 190);
            this.dataGridView3.TabIndex = 2;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(342, 325);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(74, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonRetreive
            // 
            this.buttonRetreive.Location = new System.Drawing.Point(434, 325);
            this.buttonRetreive.Name = "buttonRetreive";
            this.buttonRetreive.Size = new System.Drawing.Size(79, 23);
            this.buttonRetreive.TabIndex = 4;
            this.buttonRetreive.Text = "Retrieve";
            this.buttonRetreive.UseVisualStyleBackColor = true;
            this.buttonRetreive.Click += new System.EventHandler(this.buttonRetreive_Click);
            // 
            // buttonAggregatedMarkSort
            // 
            this.buttonAggregatedMarkSort.Location = new System.Drawing.Point(651, 325);
            this.buttonAggregatedMarkSort.Name = "buttonAggregatedMarkSort";
            this.buttonAggregatedMarkSort.Size = new System.Drawing.Size(113, 23);
            this.buttonAggregatedMarkSort.TabIndex = 6;
            this.buttonAggregatedMarkSort.Text = "Sort by Aggregated mark";
            this.buttonAggregatedMarkSort.UseVisualStyleBackColor = true;
            this.buttonAggregatedMarkSort.Click += new System.EventHandler(this.buttonAggregatedMarkSort_Click);
            // 
            // buttonSurnameSort
            // 
            this.buttonSurnameSort.Location = new System.Drawing.Point(532, 325);
            this.buttonSurnameSort.Name = "buttonSurnameSort";
            this.buttonSurnameSort.Size = new System.Drawing.Size(106, 23);
            this.buttonSurnameSort.TabIndex = 5;
            this.buttonSurnameSort.Text = "Sort by Surname";
            this.buttonSurnameSort.UseVisualStyleBackColor = true;
            this.buttonSurnameSort.Click += new System.EventHandler(this.buttonSurnameSort_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(779, 325);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(91, 23);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // buttonVerify
            // 
            this.buttonVerify.Location = new System.Drawing.Point(24, 240);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(75, 23);
            this.buttonVerify.TabIndex = 16;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseMnemonic = false;
            this.buttonVerify.UseVisualStyleBackColor = true;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // responce
            // 
            this.responce.AutoSize = true;
            this.responce.Location = new System.Drawing.Point(122, 244);
            this.responce.Name = "responce";
            this.responce.Size = new System.Drawing.Size(0, 13);
            this.responce.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(901, 593);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonAggregatedMarkSort);
            this.Controls.Add(this.buttonSurnameSort);
            this.Controls.Add(this.buttonRetreive);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textAggregatedMark;
        private System.Windows.Forms.TextBox textFinalExam;
        private System.Windows.Forms.TextBox textCoursework2;
        private System.Windows.Forms.TextBox textCoursework1;
        private System.Windows.Forms.TextBox textEmailAddress;
        private System.Windows.Forms.TextBox textSurName;
        private System.Windows.Forms.TextBox textForeName;
        private System.Windows.Forms.TextBox textStudentID;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonRetreive;
        private System.Windows.Forms.Button buttonAggregatedMarkSort;
        private System.Windows.Forms.Button buttonSurnameSort;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox textClassAverage;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.RadioButton radioButtonAlphabetical;
        private System.Windows.Forms.RadioButton radioButtonNumeric;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label responce;
        private System.Windows.Forms.Button buttonVerify;
    }
}

