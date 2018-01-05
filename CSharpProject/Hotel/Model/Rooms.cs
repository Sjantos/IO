using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Rooms
    {
        List<Room> allRooms;

        public Rooms()
        {
            allRooms = new List<Room>();
            init();
        }

        private void init()
        {
            Room przed = new Room(1, 4, "2x2", RoomStatus.Empty);
            allRooms.Add(przed);

        }
        public Rooms FindFreeRoom(DateTime startDate, DateTime endDate, int capacity)
        {
            throw new NotImplementedException();
        }

        public void CheckOutClient(int roomNumber)
        {
            ReportNeedForCleaning(roomNumber);
        }

        public void ReportNeedForCleaning(int roomNumber)
        {
            for (int i = 0; i < allRooms.Count; i++)
                if(allRooms[i].RoomNumber == roomNumber)
                {
                    allRooms[i].Status = RoomStatus.NeedCleaning;
                    break;
                }
        }

        public void ReportNeedForRepair(int roomNumber)
        {
            for (int i = 0; i < allRooms.Count; i++)
                if (allRooms[i].RoomNumber == roomNumber)
                {
                    allRooms[i].Status = RoomStatus.NeedRepairing;
                    break;
                }
        }

        public void ReportExecutionOfRepair(int roomNumber, bool occupied)
        {
            for (int i = 0; i < allRooms.Count; i++)
                if (allRooms[i].RoomNumber == roomNumber)
                {
                    if(occupied)
                        allRooms[i].Status = RoomStatus.Occupied;
                    else
                        allRooms[i].Status = RoomStatus.Empty;
                    ReportNeedForCleaning(roomNumber);
                    break;
                }
        }

        public void ReportExecutionOfCleaning(int roomNumber, bool occupied)
        {
            for (int i = 0; i < allRooms.Count; i++)
                if (allRooms[i].RoomNumber == roomNumber)
                {
                    if (occupied)
                        allRooms[i].Status = RoomStatus.Occupied;
                    else
                        allRooms[i].Status = RoomStatus.Empty;
                    break;
                }
        }

        #region getter and setters
        public Room this[int i]
        {
            get { return allRooms[i]; }
            set { allRooms[i] = value; }
        }

        internal Room[] ToArray()
        {
            return allRooms.ToArray<Room>();
        }

        internal int[] ToRoomNumberArray()
        {
            int[] numbers = new int[allRooms.Count];
            for (int i = 0; i < allRooms.Count; i++)
                numbers[i] = allRooms[i].RoomNumber;
            return numbers;
        }
        #endregion
    }
}
