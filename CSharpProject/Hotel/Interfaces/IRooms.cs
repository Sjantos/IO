using HotelProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IRooms
    {
        Rooms FindFreeRoom(DateTime startDate, DateTime endDate, int capacity);

        void CheckOutClient(int roomNumber);

        RoomStatus ReportNeedForCleaning(int roomNumber);

        void ReportNeedForRepair(int roomNumber);

        RoomStatus ReportExecutionOfRepair(int roomNumber, bool occupied);

        void ReportExecutionOfCleaning(int roomNumber, bool occupied);

        #region getter and setters
        Room this[int i] { get; }

        Room[] ToArray();

        int[] ToRoomNumberArray();

        IEnumerable<Room> AllRooms { get; }

        #endregion
    }
}
