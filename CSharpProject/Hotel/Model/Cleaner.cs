using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Cleaner : Employee, ICleaner
    {

        public Cleaner() : base() { }

        public Cleaner(String firstName, String lastName, String id, String email, String password) : base(firstName, lastName, id, email, password) { }

        public void ReportExecutionOfCleaning(int roomNumber)
        {
            throw new NotImplementedException();
        }
    }
}
