using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    class Payment
    {
        double paymentValue;
        bool income;

        public Payment()
        {
            this.paymentValue = 0.0;
            this.income = true;
        }

        public Payment(double value, bool income)
        {
            this.paymentValue = value;
            this.income = income;
        }

        #region getters and setters
        public double PaymentValue
        {
            get { return paymentValue; }
            set { paymentValue = value; }
        }

        public bool Income
        {
            get { return income; }
            set { income = value; }
        }
        #endregion
    }
}
