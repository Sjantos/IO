using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Employee : Person
    {
        String password;

        public Employee() : base()
        {
            this.password = "";
        }

        public Employee(String firstName, String lastName, String id, String email, String password) : base(firstName, lastName, id, email)
        {
            this.password = password;
        }

        #region getters and setters
        public String Password
        {
            get { return password; }
            set { password = value; }
        }
        #endregion
    }
}
