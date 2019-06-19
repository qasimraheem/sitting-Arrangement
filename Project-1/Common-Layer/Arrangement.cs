using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class Arrangement
    {
        public int id { get; set; }
        public int eventID { get; set; }
        public int adminID { get; set; }
        public int roomID { get; set; }
        public string roomSaveFile { get; set; }
        public Arrangement()
        {
           
        }
        public Arrangement(int id, int eventID, int adminID, int roomID,string roomSaveFile)
        {
            this.id= id;
            this.eventID = eventID;
            this.adminID = adminID;
            this.roomID = roomID;
            this.roomSaveFile = roomSaveFile;
        }
    }
    
}
