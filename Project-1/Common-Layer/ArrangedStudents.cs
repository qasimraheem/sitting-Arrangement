using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class ArrangedStudents
    {

        public int id { get; set; }

        public int cms { get; set; }
        public string subject { get; set; }
        public string subjectCode { get; set; }
        public string classs { get; set; }
        public int adminID { get; set; }
        public int eventID { get; set; }
        public ArrangedStudents()
        {

        }
        public ArrangedStudents(int id, int cms, string subject, string subjectCode, string classs, int adminID, int eventID)
        {
            this.classs = classs;
            this.subject = subject;
            this.subjectCode = subjectCode;
            this.id = id;
            this.cms = cms;
            this.adminID = adminID;
        }
        public void student(Student student)
        {
            this.classs = student.classs;
            this.subject = student.subject;
            this.subjectCode = student.subjectCode;
            this.cms = student.cms;
            this.adminID = student.adminID;
        }
    }
}
