using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Employees
    {
        List<Employee> allEmployees;

        public Employees()
        {
            allEmployees = new List<Employee>();
        }

        #region getters and setters
        public Employee this[int i]
        {
            get { return allEmployees[i]; }
            set { allEmployees[i] = value; }
        }
        #endregion
    }
}
