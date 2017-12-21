using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Rooms
    {
        List<Room> allRooms;

        public Rooms()
        {
            allRooms = new List<Room>();
        }

        public Rooms FindFreeRoom(DateTime startDate, DateTime endDate, int capacity)
        {
            throw new NotImplementedException();
        }

        public void CheckOutClient(int roomNumber)
        {
            throw new NotImplementedException();
        }

        #region getter and setters
        public Room this[int i]
        {
            get { return allRooms[i]; }
            set { allRooms[i] = value; }
        }
        #endregion
    }
}
