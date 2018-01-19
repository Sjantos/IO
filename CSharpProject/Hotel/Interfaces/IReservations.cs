﻿using HotelProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Interfaces
{
    public interface IReservations
    {
        void MakeReservation(String clientID, DateTime startDate, DateTime endDate, int roomNumber);

        void CancelReservation(String reservationID);

        RoomStatus CheckInClient(String reservationID, IRooms roomsCollection); //dostęp do allRooms

        void CheckOutClient(String reservationID); //czy zamienic CheckOutClient na statyczną?

        int[] FindFreeRoom(DateTime startDate, DateTime endDate, int capacity, Rooms roomsCollection);

        #region getters and setters
        Reservation this[int i]{ get; set; }
        IEnumerable<Reservation> AllReservations { get; }
        #endregion
    }
}
