using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class Room
    {

        public int roomID { get; set; }
        public string roomNumber { get; set; }
        public int rows { get; set; }
        public int cols { get; set; }
      

        public int totalSeats { get; set; }
        public int adminID { get; set; }
        public Room()
        {

        }
        public Room(int roomID, int rows, int cols, int totalSeats, int adminID,string roomNumber)
        {
            this.roomID = roomID;
            this.rows = rows;
            this.cols = cols;
            this.totalSeats = totalSeats;
            this.adminID = adminID;
            this.roomNumber = roomNumber;
        }
    }
}
