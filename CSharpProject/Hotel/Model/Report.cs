using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Model
{
    class Report
    {
        DateTime date;
        double cash;
        double card;

        public Report()
        {
            this.date = new DateTime(2000, 1, 1, new System.Globalization.GregorianCalendar());
            this.cash = 0.0;
            this.card = 0.0;
        }

        public Report(DateTime date, double cash, double card)
        {
            this.date = date;
            this.cash = cash;
            this.card = card;
        }

        //------------------ GETTERS AND SETTERS-----------------

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public double Cash
        {
            get { return cash; }
            set { cash = value; }
        }

        public double Card
        {
            get { return card; }
            set { card = value; }
        }
    }
}
