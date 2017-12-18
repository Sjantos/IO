using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Payments
    {
        List<Payment> allPayments;
        double actualCash;
        double actualCard;

        public Payments()
        {
            allPayments = new List<Payment>();
            actualCard = 0.0;
            actualCash = 0.0;
        }

        public void PayOutSalary(String employeeID, double salary)
        {
            throw new NotImplementedException();
        }

        public void TakePayment(double paymentValue, bool card)
        {
            throw new NotImplementedException();
        }

        public void GiveBonus(String employeeID, int percentageBonus)
        {
            throw new NotImplementedException();
        }

        //------------------ GETTERS AND SETTERS-----------------

        public Payment this[int i]
        {
            get { return allPayments[i]; }
            set { allPayments[i] = value; }
        }

        public double ActualCash
        {
            get { return actualCash; }
            set { actualCash = value; }
        }

        public double ActualCard
        {
            get { return actualCard; }
            set { actualCard = value; }
        }
    }
}
