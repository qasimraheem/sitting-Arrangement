using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Common_Layer
{
    class EventType
    {
        public int id { get; set; }
        public string eventType { get; set; }

        public EventType() { }

        public EventType(int id, string eventType) {
            this.id = id;
            this.eventType = eventType;
        }
    }
}
