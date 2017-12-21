using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Client : Person
    {
        Reservations reservations;

        public Client() : base() { }
        public Client(String firstName, String lastName, String id, String email) : base(firstName, lastName, id, email) { }

        #region getters and setters
        public Reservations Reservations
        {
            get { return reservations; }
        }
        #endregion
    }
}
