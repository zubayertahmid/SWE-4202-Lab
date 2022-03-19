using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Making_Specs
{
    internal class LectureRoom
    {
        private string name;
        private string roomNumber;
        private string capacity;

        public string RoomName()
        {
            return name;
        }

        public void setName(string roomName)
        {
            name = roomName;
        }

        public string Capacity()
        {
            return capacity;
        }

        public void setCapacity(string capacit)
        {
            capacity = capacit;
        }
    }
}
