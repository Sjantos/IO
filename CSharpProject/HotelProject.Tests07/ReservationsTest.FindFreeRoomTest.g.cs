using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelProject.Model;

using System;
using Hotel.Interfaces;
using Moq;

namespace HotelProject.Model.Tests
{
    public partial class ReservationsTest
    {

        [TestMethod]
        [PexGeneratedBy(typeof(ReservationsTest))]
        [PexRaisedException(typeof(ArgumentOutOfRangeException))]
        public void FindFreeRoomTest1()
        {
            Mock<IReservations> reservationsMock = new Mock<IReservations>();
            reservationsMock.Setup(m => m.AllReservations).Returns(new Reservation[] {
                new Reservation("0", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "3", 2),
                new Reservation("1", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "2", 4),
                new Reservation("2", new DateTime(2017, 01, 15), new DateTime(2017, 01, 17), "1", 2)
            });
            int[] result = this.FindFreeRoomTest(reservationsMock.Object, new DateTime(2017, 1, 12), new DateTime(2017, 1, 13), 3);
            CollectionAssert.AreEqual(result, new int[] { });
        }

        [TestMethod]
        [PexGeneratedBy(typeof(ReservationsTest))]
        [PexRaisedException(typeof(NullReferenceException))]
        public void FindFreeRoomTest0()
        {
            Mock<IReservations> reservationsMock = new Mock<IReservations>();
            reservationsMock.Setup(m => m.AllReservations).Returns(new Reservation[] {
                new Reservation("0", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "3", 2),
                new Reservation("1", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "2", 4),
                new Reservation("2", new DateTime(2017, 01, 15), new DateTime(2017, 01, 17), "1", 2)
            });
            int[] result = this.FindFreeRoomTest(reservationsMock.Object, new DateTime(2017, 2, 12), new DateTime(2017, 2, 13), 3);
            //CollectionAssert.AreEqual(result, new int[] { 2, 4 });
            Assert.AreEqual(2, result.Length);
        }
    }
}
