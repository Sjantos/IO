using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Reservations
    {
        List<Reservation> allReservations;

        public Reservations()
        {
            allReservations = new List<Reservation>();
        }

        public void MakeReservation(String clientID, DateTime startDate, DateTime endDate, int roomNumber)
        {
            if (true) // tu ma być wywołana funkcja FindFreeRoom ale nie wiem jakie parametry
            {
                int idr=0;
                if (allReservations.Count!=0)
                idr = Int32.Parse(allReservations[allReservations.Count - 1].ReservationID) + 1;
                Reservation iten = new Reservation(idr.ToString(), startDate, endDate, clientID, roomNumber);
                allReservations.Add(iten);
            }
        }

        public void CancelReservation(String reservationID)
        {
            //reservationID = allReservations.Find(x => x.ReservationID.Contains(reservationID)).ReservationID; //trochę się rozpędziłem
            allReservations.RemoveAt(Int32.Parse(reservationID));
        }

        public void CheckInClient(String reservationID) //dostęp do allRooms
        {
            int roomnum = allReservations.Find(x => x.ReservationID.Contains(reservationID)).RoomNumber;
            if(Rooms.allRooms[roomnum].Status == RoomStatus.Empty)
            Rooms.allRooms[roomnum].Status = RoomStatus.Occupied;
        }

        public void CheckOutClient(String reservationID) //czy zamienic CheckOutClient na statyczną?
        {
            int roomnum = allReservations.Find(x => x.ReservationID.Contains(reservationID)).RoomNumber;
            Rooms.CheckOutClient(roomnum); 
        }

        public int[] FindFreeRoom(DateTime startDate, DateTime endDate, int capacity, Rooms roomsCollection)
        {
            if (allReservations.Count == 0)
                return new int[0];
            else
            {
                int index = 0;
                Room[] rooms = roomsCollection.ToArray();
                List<int> availableRooms = new List<int>(roomsCollection.ToRoomNumberArray());
                while(index < allReservations.Count)
                {
                    int roomNumber = allReservations[index].RoomNumber;
                    int i = 0;
                    for (i = 0; i < rooms.Length; i++)
                    {
                        if (rooms[i].RoomNumber == roomNumber)
                            break;
                    }
                    bool capacityIF = capacity == rooms[i].Capacity;
                    bool firstDateIF = (startDate < allReservations[index].StartDate) && (endDate <= allReservations[index].StartDate);
                    bool secondDateIF = (startDate > allReservations[index].EndDate) && (endDate >= allReservations[index].EndDate);

                    if (!(capacityIF && firstDateIF && secondDateIF))
                        availableRooms.Remove(roomNumber);
                    index++;
                }

                return availableRooms.ToArray<int>();
            }
        }

        #region getters and setters
        public Reservation this[int i]
        {
            get { return allReservations[i]; }
            set { allReservations[i] = value; }
        }
        #endregion
    }
}
