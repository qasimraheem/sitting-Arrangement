using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Project_1.Common_Layer
{
    public class Event_Arrange
    {
        public int id { get; set; }
        public string name { get; set; }
        public int typeID { get; set; }
        public string eventStartDateTime { get; set; }
        public string eventEndDateTime { get; set; }

        public Event_Arrange() {

        }

        public Event_Arrange(int id, string name, int typeID, string eventStartDateTime, string eventEndDateTime) {
            this.id = id;
            this.name = name;
            this.typeID = typeID;
            this.eventStartDateTime = eventStartDateTime;
            this.eventEndDateTime = eventEndDateTime;
        }

        public void print() {
            string output = "";
            output += "ID:" + id.ToString()+"\n";
            output += "Name:" + name + "\n";
            output += "TypeID:" + typeID+ "\n";
            output += "Start:" + eventStartDateTime+ "\n";
            output += "End:" + eventEndDateTime + "\n";


            MessageBox.Show(output);
        }
    }
}
