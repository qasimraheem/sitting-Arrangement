using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class Student
    {
        public string id { get; set; }
        public string subject { get; set; }
        public string subjectCode { get; set; }
        public string classs { get; set; }

        public int arrangementID { get; set; }
        public int adminID { get; set; }
        public Student()
        {

        }
        public Student(string id, string subject, string subjectCode, string classs,int arrangementID,int adminID)
        {
            this.classs = classs;
            this.subject = subject;
            this.subjectCode = subjectCode;
            this.id = id;
            this.arrangementID = arrangementID;
            this.adminID = adminID;
        }

    }
}
