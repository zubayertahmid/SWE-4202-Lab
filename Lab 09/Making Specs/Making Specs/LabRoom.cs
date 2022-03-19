using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Specs
{
    internal class LabRoom
    {
        private string name;
        
        private string capacity;

        public string LabRoomName()
        {
            return name;
        }

        public void setLabName(string roomName)
        {
            name = roomName;
        }

        public string LabCapacity()
        {
            return capacity;
        }

        public void setLabCapacity(string capacit)
        {
            capacity = capacit;
        }
    }
}
