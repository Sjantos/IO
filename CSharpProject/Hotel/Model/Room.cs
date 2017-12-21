using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    public enum RoomStatus
    {
        NoNeeds,
        NeedCleaning,
        NeedRepairing
    }

    class Room
    {
        int roomNumber;
        int capacity;
        String beds;
        RoomStatus status;

        public Room()
        {
            this.roomNumber = 0;
            this.capacity = 0;
            this.beds = "";
            this.status = RoomStatus.NoNeeds;
        }

        public Room(int roomNumber, int capacity, String beds, RoomStatus status = RoomStatus.NoNeeds)
        {
            this.roomNumber = roomNumber;
            this.capacity = capacity;
            this.beds = beds;
            this.status = status;
        }

        #region getters and setters
        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public String Beds
        {
            get { return beds; }
            set { beds = value; }
        }

        public RoomStatus Status
        {
            get { return status; }
            set { status = value; }
        }
        #endregion
    }
}
