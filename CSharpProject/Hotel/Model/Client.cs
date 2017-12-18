using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Client : Person
    {
        Reservation reservation;

        public Client() : base() { }
        public Client(String firstName, String lastName, String id, String email) : base(firstName, lastName, id, email) { }
    }
}
