using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Manager : Employee, IManager, IReceptionist, IRepairman, ICleaner
    {
        public Manager() : base() { }

        public Manager(String firstName, String lastName, String id, String email, String password) : base(firstName, lastName, id, email, password) { }

        public void AddDailyReport()
        {
            throw new NotImplementedException();
        }

        public void CalculateSalary(string employeeID)
        {
            throw new NotImplementedException();
        }

        public void CallEmployee(string employeeID)
        {
            throw new NotImplementedException();
        }

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

        public void FireEmployee(string employeeID)
        {
            throw new NotImplementedException();
        }

        public void GiveBonus(string employeeID, double bonus)
        {
            throw new NotImplementedException();
        }

        public void MakeReservation(string clientID, DateTime startDate, DateTime endDate, int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void PayOutSalary(string employeeID)
        {
            throw new NotImplementedException();
        }

        public void PrintAndArchiveReport(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void RegisterClient(string lastName, string firstName, string clientID, string email)
        {
            throw new NotImplementedException();
        }

        public void ReportExecutionOfCleaning(int roomNumber)
        {
            throw new NotImplementedException();
        }

        public void ReportExecutionOfRepair(int roomNumber)
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

        public void ViewReports()
        {
            throw new NotImplementedException();
        }

        public void WarnEmployee(string employeeID)
        {
            throw new NotImplementedException();
        }
    }
}
