using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Model
{
    interface ICleaner
    {
        void ReportExecutionOfCleaning(int roomNumber);
    }
}
