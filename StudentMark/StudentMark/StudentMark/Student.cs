using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Collections;

namespace StudentMark
{
    [Serializable()] //Set this attribute to all classes that wants to serialize
    public class Student : ISerializable, IComparable
    {

        private string studentID;
        private string surName = "";
        private string foreName = "";
        private string emailAddress = "";
        private double coursework1;
        private double coursework2;
        private double finalExam;


        //Default constructor
        
        public Student (string studentIDnum)
        {
            this.studentID = studentIDnum;
        }
        
        public string StudentID
        {

            get { return studentID; }
            set { studentID = value; }
        }


        public string SurName
        {

            get { return surName; }
            set { surName = value; }

        }


        public string ForeName
        {

            get { return foreName; }
            set { foreName = value; }

        }


        public string EmailAddress
        {

            get { return emailAddress; }
            set { emailAddress = value; }

        }



        public double Coursework1
        {

            get { return coursework1; }
            set { coursework1 = value; }

        }


        public double Coursework2
        {

            get { return coursework2; }
            set { coursework2 = value; }

        }


        public double FinalExam
        {

            get { return finalExam; }
            set { finalExam = value; }

        }


        //Serialization (save) function
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("StudentID", StudentID);
            info.AddValue("SurName", SurName);
            info.AddValue("ForeName", ForeName);
            info.AddValue("EmailAddress", EmailAddress);
            info.AddValue("Coursework1", Coursework1);
            info.AddValue("Coursework2", Coursework2);
            info.AddValue("FinalExam", FinalExam);

           
        }

        //Deserialization (Retrieve) function
        public Student(SerializationInfo info, StreamingContext ctxt)
        {
            StudentID = (string)info.GetValue("StudentID", typeof(string));
            SurName = (String)info.GetValue("SurName", typeof(string));
            ForeName = (String)info.GetValue("ForeName", typeof(string));
            EmailAddress = (String)info.GetValue("EmailAddress", typeof(string));
            Coursework1 = (Double)info.GetValue("Coursework1", typeof(double));
            Coursework2 = (Double)info.GetValue("Coursework2", typeof(double));
            FinalExam = (Double)info.GetValue("FinalExam", typeof(double));

        

        }

        //Providing default sort order for the Employee objects

        public int CompareTo(object obj)
        { 
            if (!(obj is Student))
            {
                throw new ArgumentException("object is not a student");

            }
            Student student = (Student)obj;
            return this.SurName.CompareTo(student.SurName);
        }

        //Method
        //Calculating 30% of cw1, cw2 and 40% of final exam
        public double CourseMark()
        {
            return (((this.coursework1 * 0.3) + (this.coursework2 * 0.3) + (this.finalExam * 0.4)));
        }

        //Method
        //Nested class to do the sorting by aggregated mark

        private class sortbyAggregatedMarkHelper : IComparer
        {
            int IComparer.Compare(object a, object b)
            {
                Student std1 = (Student)a;
                Student std2 = (Student)b;
                if (std1.CourseMark() < std2.CourseMark())
                { 
                    return -1;
                }
                if (std1.CourseMark() == std2.CourseMark())
                {
                    return 0;
                }
                return 1;
            }
        }

        //Method to returner IComparer object for sort helper.

        public static IComparer sortByAggregatedMark()
        {
            return (IComparer)new sortbyAggregatedMarkHelper();
        }

    }
}



