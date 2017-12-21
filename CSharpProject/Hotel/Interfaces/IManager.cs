using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    interface IManager
    {
        void ViewReports();
        void PrintAndArchiveReport(DateTime date);
        void AddDailyReport();
        void PayOutSalary(String employeeID);
        void GiveBonus(String employeeID, double bonus);
        void CalculateSalary(String employeeID);
        void FireEmployee(String employeeID);
        void CallEmployee(String employeeID);
        void WarnEmployee(String employeeID);
    }
}
