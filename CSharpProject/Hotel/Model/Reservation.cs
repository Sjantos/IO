using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    public class Reservation
    {
        String reservationID;
        DateTime startDate;
        DateTime endDate;
        String clientID;
        int roomNumber;

        public Reservation()
        {
            this.reservationID = "";
            this.startDate = new DateTime(2000, 1, 1, new System.Globalization.GregorianCalendar());
            this.endDate = new DateTime(2000, 1, 1, new System.Globalization.GregorianCalendar());
            this.clientID = "";
            this.roomNumber = 0;
        }

        public Reservation(String reservationID, DateTime startDate, DateTime endDate, String clientID, int roomNumber)
        {
            this.reservationID = reservationID;
            this.startDate = startDate;
            this.endDate = endDate;
            this.clientID = clientID;
            this.roomNumber = roomNumber;
        }

        #region getters and setters
        public String ReservationID
        {
            get { return reservationID; }
            set { reservationID = value; }
        }

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public String ClientID
        {
            get { return clientID; }
            set { clientID = value; }
        }

        public int RoomNumber
        {
            get { return roomNumber; }
            set { roomNumber = value; }
        }
        #endregion
    }
}
