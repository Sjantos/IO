using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    public class Rooms
    {
        List<Room> allRooms;

        public Rooms()
        {
            allRooms = new List<Room>();
            init();
        }

        private void init()
        {
            Room przed = new Room(0, 4, "2x2", RoomStatus.Empty);
            allRooms.Add(przed);
            przed = new Room(1, 2, "1x2", RoomStatus.Occupied);
            allRooms.Add(przed);
            przed = new Room(2, 3, "1x2+1x1", RoomStatus.Empty);
            allRooms.Add(przed);
            przed = new Room(3, 1, "1x1", RoomStatus.Occupied);
            allRooms.Add(przed);
            przed = new Room(4, 3, "3x1", RoomStatus.Empty);
            allRooms.Add(przed);
            przed = new Room(5, 2, "2x1", RoomStatus.Empty);
            allRooms.Add(przed);
            przed = new Room(6, 2, "1x2", RoomStatus.Empty);
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

        public RoomStatus ReportNeedForCleaning(int roomNumber)
        {
            int i = 0;
            for (i = 0; i < allRooms.Count; i++)
                if(allRooms[i].RoomNumber == roomNumber)
                {
                    allRooms[i].Status = RoomStatus.NeedCleaning;
                    break;
                }

            return allRooms[i].Status;
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

        public RoomStatus ReportExecutionOfRepair(int roomNumber, bool occupied)
        {
            int i;
            for ( i = 0; i < allRooms.Count; i++)
                if (allRooms[i].RoomNumber == roomNumber)
                {
                    if(occupied)
                        allRooms[i].Status = RoomStatus.Occupied;
                    else
                        allRooms[i].Status = RoomStatus.Empty;
                    ReportNeedForCleaning(roomNumber);
                    break;
                }
            return allRooms[i].Status;
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
        internal Room this[int i]
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
