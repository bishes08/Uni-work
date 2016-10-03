using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;


namespace StudentMark
{
    public partial class Form1 : Form
    {
        ArrayList StudentList = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        //Serialization (Save to file)
        private void buttonSave_Click(object sender, EventArgs e)
        {           
      
  
            Stream serializationStream = File.Open("StudentDetails.dat", FileMode.Create);
            BinaryFormatter bformatter = new BinaryFormatter();
            bformatter.Serialize(serializationStream, this.StudentList);
            serializationStream.Close();
            MessageBox.Show("Students and Marks Data saved to file");
        }


        //De-Serialization (retrieve from file)
        private void buttonRetreive_Click(object sender, EventArgs e)
        {
            try
            {
               
                Stream serializationStream = File.Open("StudentDetails.dat", FileMode.Open);
                BinaryFormatter bformatter = new BinaryFormatter();

                this.StudentList = (ArrayList)bformatter.Deserialize(serializationStream);
                serializationStream.Close();

          
                this.radioButtonNumeric.Select();
                this.dataGridView3.Columns.Clear();
                this.dataGridView3.DataSource = null;
                this.dataGridView3.DataSource = this.StudentList;
                this.textClassAverage.Text = this.CalculateClassAverageMark();
                this.DisplayBarChart();
                MessageBox.Show("Student & Marks data retrieved from file");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ERROR reading file!");
            }
        }

        //Add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {
         
            foreach (object o in this.StudentList)
            {
                string str = ((Student)o).StudentID.ToUpper();
  
                if (str.CompareTo(this.textStudentID.Text.ToUpper()) == 0)
                {
                    string message = "Student with ID = " + str + " already exists!\n Do you really want to update this student's record with new details?";
                    string caption = "Student already exists!";
                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                    if (MessageBox.Show(message, caption, button) == DialogResult.Yes)
                    {
                        ((Student)o).ForeName = this.textForeName.Text;
                        ((Student)o).SurName = this.textSurName.Text;
                        ((Student)o).EmailAddress = this.textEmailAddress.Text;
                        ((Student)o).Coursework1 = Convert.ToDouble(this.textCoursework1.Text);
                        ((Student)o).Coursework2 = Convert.ToDouble(this.textCoursework2.Text);
                        ((Student)o).FinalExam = Convert.ToDouble(this.textFinalExam.Text);
                        this.textAggregatedMark.Text = ((Student)o).CourseMark().ToString();
                        MessageBox.Show(((Student)o).SurName + " record has been updated with new details, except the ID.");
                        this.dataGridView3.DataSource = null;
                        this.dataGridView3.DataSource = this.StudentList;
                        this.textClassAverage.Text = this.CalculateClassAverageMark();
                        this.DisplayBarChart();


                    }
                    return;

                }
            }

       
            Student newStudent = new Student(this.textStudentID.Text)
            {
                ForeName = this.textForeName.Text,
                SurName = this.textSurName.Text,
                EmailAddress = this.textEmailAddress.Text,
                Coursework1 = Convert.ToDouble(this.textCoursework1.Text),
                Coursework2 = Convert.ToDouble(this.textCoursework2.Text),
                FinalExam = Convert.ToDouble(this.textFinalExam.Text)
            };
            this.textAggregatedMark.Text = newStudent.CourseMark().ToString();
            this.StudentList.Add(newStudent);
            MessageBox.Show(newStudent.SurName + " has been added to the student list");
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = this.StudentList;
            this.textClassAverage.Text = this.CalculateClassAverageMark();
            this.DisplayBarChart();
        }

        //Sort by Surname
        private void buttonSurnameSort_Click(object sender, EventArgs e)
        {
            this.StudentList.Sort();
            this.radioButtonNumeric.Select();
            this.dataGridView3.Columns.Clear();
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = this.StudentList;
        }

        //Sort by Numerical
        private void buttonAggregatedMarkSort_Click(object sender, EventArgs e)
        {
            this.StudentList.Sort(Student.sortByAggregatedMark());
            this.radioButtonNumeric.Select();
            this.dataGridView3.Columns.Clear();
            this.dataGridView3.DataSource = null;
            this.dataGridView3.DataSource = this.StudentList;
        }

        //Class average mark calculation
        private string CalculateClassAverageMark()
        {
            double num2 = 0.0;
            foreach (Student student in this.StudentList)
            {
                num2 += student.CourseMark();
            }
            return Math.Round((double)(num2 / (double)this.StudentList.Count), 2).ToString();
        }

        private string LetterGrade(double grade)
        {
            if (grade < 40.0)
            {
                return "F";
            }
            if (grade < 43.0)
            {
                return "E";
            }
            if (grade < 50.0)
            {
                return "D";
            }
            if (grade < 60.0)
            {
                return "C";
            }
            if (grade < 70.0)
            {
                return "B";
            }
            return "A";
        }

        //Barchart 
        private void DisplayBarChart()
        {
            int num;
            int[] source = new int[6];
            for (num = 0; num < this.StudentList.Count; num++)
            {
                string str4 = this.LetterGrade(((Student)this.StudentList[num]).CourseMark());
                if (str4 != null)
                {
                    if (!(str4 == "A"))
                    {
                        if (str4 == "B")
                        {
                            goto Label_00A6;
                        }
                        if (str4 == "C")
                        {
                            goto Label_00BC;
                        }
                        if (str4 == "D")
                        {
                            goto Label_00D2;
                        }
                        if (str4 == "E")
                        {
                            goto Label_00E8;
                        }
                        if (str4 == "F")
                        {
                            goto Label_00FE;
                        }
                    }
                    else
                    {
                        source[0]++;
                    }
                }
                continue;
            Label_00A6:
                source[1]++;
                continue;
            Label_00BC:
                source[2]++;
                continue;
            Label_00D2:
                source[3]++;
                continue;
            Label_00E8:
                source[4]++;
                continue;
            Label_00FE:
                source[5]++;
            }
            this.listBox3.Items.Clear();
            for (int i = 0; i < source.Count<int>(); i++)
            {
                string str2 = "";
                switch (i)
                {
                    case 0:
                        str2 = "A: ";
                        break;

                    case 1:
                        str2 = "B: ";
                        break;

                    case 2:
                        str2 = "C: ";
                        break;

                    case 3:
                        str2 = "D: ";
                        break;

                    case 4:
                        str2 = "E: ";
                        break;

                    case 5:
                        str2 = "F: ";
                        break;
                }
                for (int j = 1; j <= source[i]; j++)
                {
                    str2 = str2 + "*";
                }
                this.listBox3.Items.Add(str2);
            }
            this.chart3.Series.Clear();
            this.chart3.Palette = ChartColorPalette.BrightPastel;
            this.chart3.BackColor = Color.LightYellow;
            this.chart3.Titles.Clear();
            this.chart3.Titles.Add("Students on Grades");
            this.chart3.ChartAreas[0].BackColor = Color.Transparent;
            Series item = new Series
            {
                Name = "series1",
                IsVisibleInLegend = true,
                Color = Color.Green,
                ChartType = SeriesChartType.Pie
            };
            this.chart3.Series.Add(item);
            for (num = 0; num < source.Count<int>(); num++)
            {
                item.Points.Add(new double[] { (double)source[num] });
                DataPoint point = item.Points[num];
                point.AxisLabel = source[num].ToString();
                string str3 = "";
                switch (num)
                {
                    case 0:
                        str3 = "A";
                        break;

                    case 1:
                        str3 = "B";
                        break;

                    case 2:
                        str3 = "C";
                        break;

                    case 3:
                        str3 = "D";
                        break;

                    case 4:
                        str3 = "E";
                        break;

                    case 5:
                        str3 = "F";
                        break;
                }
                point.LegendText = str3;
                this.chart3.Series[0].Points[num].ToolTip = str3;
                this.chart3.Series[0].LegendToolTip = "#VAL students achieved #LEGENDTEXT";
            }
            this.chart3.Invalidate();
        }

     
        //Radio button
        private void radioButtonNumeric_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radioButtonAlphabetical.Checked)
            {
                MessageBox.Show("Show letter grades");
                this.dataGridView3.DataSource = null;
                this.dataGridView3.Columns.Add("studentID", "StudentID");
                this.dataGridView3.Columns.Add("foreName", "ForeName");
                this.dataGridView3.Columns.Add("surName", "SurName");
                this.dataGridView3.Columns.Add("emailAddress", "EmailAddress");
                this.dataGridView3.Columns.Add("coursework1", "Coursework1");
                this.dataGridView3.Columns.Add("coursework2", "Coursework2");
                this.dataGridView3.Columns.Add("finalexam", "FinalExam");
                for (int i = 0; i < this.StudentList.Count; i++)
                {
                    this.dataGridView3.Rows.Add(new object[] 
                    { ((Student)this.StudentList[i]).StudentID, ((Student)this.StudentList[i]).ForeName,
                        ((Student)this.StudentList[i]).SurName, ((Student)this.StudentList[i]).EmailAddress, 
                        this.LetterGrade(((Student)this.StudentList[i]).Coursework1),
                        this.LetterGrade(((Student)this.StudentList[i]).Coursework2),
                        this.LetterGrade(((Student)this.StudentList[i]).FinalExam) });
                }
                this.dataGridView3.Refresh();
            }
            if (this.radioButtonNumeric.Checked)
            {
                MessageBox.Show("Show numeric marks");
                this.dataGridView3.Columns.Clear();
                this.dataGridView3.DataSource = null;
                this.dataGridView3.DataSource = this.StudentList;
                this.textClassAverage.Text = this.CalculateClassAverageMark();
            }
        }

        //Exit application
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textCoursework1_Validated(object sender, EventArgs e)
        {           
                this.errorProvider2.SetError(this.textCoursework1, "");    
        }


        private void textCoursework1_Validating_1(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textCoursework1.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textCoursework1.Select(0, this.textCoursework1.Text.Length);
                string str = "Please enter a number between 0 and 100";
                this.errorProvider2.SetError(this.textCoursework1, str);
            }
        }

        private void textCoursework2_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(this.textCoursework1, ""); 
        }

        private void textCoursework2_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textCoursework1.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textCoursework1.Select(0, this.textCoursework1.Text.Length);
                string str = "Please enter a number between 0 and 100";
                this.errorProvider2.SetError(this.textCoursework1, str);
            }
        }

        private void textFinalExam_Validated(object sender, EventArgs e)
        {
            this.errorProvider2.SetError(this.textFinalExam, ""); 
        }

        private void textFinalExam_Validating(object sender, CancelEventArgs e)
        {
            int result = 0;
            if ((!int.TryParse(this.textFinalExam.Text, out result) || (result < 0)) || (result > 100)) // Lets the user input the number between 0 and 100
            {
                e.Cancel = true;
                this.textFinalExam.Select(0, this.textFinalExam.Text.Length);
                string str = "Please enter a number between 0 and 100";
                this.errorProvider2.SetError(this.textFinalExam, str);
            }
        }

        private void textSurName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) // Lets the user use letter, backspace and the space key
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textForeName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) // Lets the user use letter, backspace and the space key
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void buttonVerify_Click(object sender, EventArgs e)
        {
            string email = textEmailAddress.Text;
            if (email.IndexOf('@') == -1 || email.IndexOf('.') == -1) // "@" and "." not included
            {
                this.responce.Text = "Invalid Email";
            }
            else
            {
                this.responce.Text = "Valid Email Address";
            }
        }    
    }

}
