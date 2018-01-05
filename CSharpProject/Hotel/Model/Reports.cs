using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Reports
    {
        List<Report> allReports;

        public Reports()
        {
            allReports = new List<Report>();
        }

        public Reports ViewReports(DateTime fromDate, DateTime toDate)
        {
            throw new NotImplementedException();
        }

        public void PrintAndArchive(DateTime date)
        {
            throw new NotImplementedException();
        }

        public void AddDailyReport(DateTime date, double cash, double card)
        {
            throw new NotImplementedException();
        }

        #region getters and setters
        public Report this[int i]
        {
            get { return allReports[i]; }
            set { allReports[i] = value; }
        }
        #endregion
    }
}
