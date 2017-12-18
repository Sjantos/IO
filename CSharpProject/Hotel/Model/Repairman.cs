using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Repairman : Employee, IRepairman
    {
        public Repairman() : base() { }

        public Repairman(String firstName, String lastName, String id, String email, String password) : base(firstName, lastName, id, email, password) { }

        public void ReportExecutionOfRepair(int roomNumber)
        {
            throw new NotImplementedException();
        }
    }
}
