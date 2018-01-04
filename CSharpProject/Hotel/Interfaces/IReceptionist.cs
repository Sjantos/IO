using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    interface IReceptionist
    {
        void MakeReservation(String clientID, DateTime startDate, DateTime endDate, int roomNumber);
        void TakePayment(String clientID, double value, bool card);
        void RegisterClient(String lastName, String firstName, String clientID, String email);
        Room[] FindFreeRoom(DateTime startDate, DateTime endDate, int capacity);
        void CheckInClient(String reservationID);
        void CancelReservation(String reservationID);
        void CheckOutClient(String reservationID);
        Client FindClient(String clientID);
        void CallManager(String place);
        void ReportNeedForCleaning(int roomNumber);
        void ReportNeedForRepair(int roomNumber);
        void ReportNeedForSecurityIntervention(int roomNumber);
    }
}
