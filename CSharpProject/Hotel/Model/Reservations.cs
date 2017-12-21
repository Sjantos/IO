using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
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
            throw new NotImplementedException();
        }

        public void CancelReservation(String reservationID)
        {
            throw new NotImplementedException();
        }

        public void CheckInClient(String reservationID)
        {
            throw new NotImplementedException();
        }

        public void CheckOutClient(String reservationID)
        {
            throw new NotImplementedException();
        }

        public void FindFreeRoom(DateTime startDate, DateTime endDate, int capacity)
        {
            throw new NotImplementedException();
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
