using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Documentation
    {
        Payments paymentsCollection;
        Reports reportsCollection;

        public Documentation()
        {
            paymentsCollection = new Payments();
            reportsCollection = new Reports();
        }

        public Reports VeiwReports(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public void PrintAndArchiveReport(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddDailyReport(DateTime date, double cash, double card)
        {
            throw new NotImplementedException();
        }

        public void PayOutSalary(String employeeID, double salary)
        {
            throw new NotImplementedException();
        }

        public void GiveBonus(String employeeID, int percentageBonus)
        {
            throw new NotImplementedException();
        }

        public void TakePayment(double paymentValue, bool card)
        {
            throw new NotImplementedException();
        }

        public void SumActualPaymentsForDailyReport()
        {
            throw new NotImplementedException();
        }
    }
}
