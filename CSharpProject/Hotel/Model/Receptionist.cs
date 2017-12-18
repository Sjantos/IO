using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Receptionist : Employee, IReceptionist
    {
        public Receptionist() : base() { }

        public Receptionist(String firstName, String lastName, String id, String email, String password) : base(firstName, lastName, id, email, password) { }

        public void CallManager(string place)
        {
            throw new NotImplementedException();
        }

        public void CancelReservation(string reservationID)
        {
            throw new NotImplementedException();
        }

        public void CheckInClient(string reservationID)
        {
            throw new NotImplementedException();
        }

        public void CheckOutClient(string reservationID)
        {
            throw new NotImplementedException();
        }

        public Client FindClient(string clientID)
        {
            throw new NotImplementedException();
        }

        public Room[] FindFreeRoom(DateTime startDate, DateTime endDate, int capacity)
        {
            throw new NotImplementedException();
        }

        public void MakeReservation(string clientID, DateTime startDate, DateTime endDate, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void RegisterClient(string lastName, string firstName, string clientID, string email)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForCleaning(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForRepair(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportNeedForSecurityIntervention(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void TakePayment(string clientID, double value, bool card)
        {
            throw new NotImplementedException();
        }
    }
}
