using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class Group
    {
        public int id { get; set; }
        public string name { get; set; }
        public int eventID { get; set; }

        public int adminID { get; set; }

        public Group() {

        }
        public Group(int id, string name, int eventID,int adminID)
        {
            this.id = id;
            this.name = name;
            this.eventID = eventID;
            this.adminID = adminID;

        }
    }
}
