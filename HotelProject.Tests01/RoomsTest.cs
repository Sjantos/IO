// <copyright file="RoomsTest.cs">Copyright ©  2017</copyright>
using System;
using HotelProject.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelProject.Model.Tests
{
    public partial class RoomsTest
    {
        public void ReportNeedForCleaningTest1()
        {
            var r = new Rooms();
            var s = new RoomStatus();
            s = r.ReportNeedForCleaning(1);
            Assert.AreEqual(RoomStatus.NeedCleaning, s);
            
            
            // TODO: dodaj asercje do metoda RoomsTest.ReportNeedForCleaningTest1(Rooms, Int32)
        }
    }
}
