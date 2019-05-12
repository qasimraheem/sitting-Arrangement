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
        public string arrangementName { get; set; }
        public int adminID { get; set; }
        public int roomID { get; set; }
        public string roomSaveFile { get; set; }
        public Arrangement()
        {

        }
        public Arrangement(int id, string arrangementName, int adminID, int roomID,string roomSaveFile)
        {
            this.id= id;
            this.arrangementName= arrangementName;
            this.adminID = adminID;
            this.roomID = roomID;
            this.roomSaveFile = roomSaveFile;
        }
    }
    
}
