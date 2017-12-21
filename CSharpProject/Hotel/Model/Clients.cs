using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Clients
    {
        List<Client> allClients;

        public Clients()
        {
            allClients = new List<Client>();
        }

        public void RegisterClient(String firstName, String lastName, String clientID, String email)
        {
            throw new NotImplementedException();
        }

        #region getters and setters
        public Client this[int i]
        {
            get { return allClients[i]; }
            set { allClients[i] = value; }
        }
        #endregion
    }
}
