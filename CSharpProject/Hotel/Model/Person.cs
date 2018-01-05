using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Person
    {
        String lastName;
        String firstName;
        String id;
        String email;

        public Person()
        {
            this.firstName = "";
            this.lastName = "";
            this.id = "";
            this.email = "";
        }

        public Person(String firstName, String lastName, String id, String email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.email = email;
        }

        #region getters and setters
        public String LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public String FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public String ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion
    }
}
