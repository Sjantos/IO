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
public void CheckInClientTest1()
{
            Mock<IReservations> reservationsMock = new Mock<IReservations>();
            reservationsMock.Setup(m => m.AllReservations).Returns(new Reservation[] {
            new Reservation("0", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "3", 2),
            new Reservation("1", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "2", 4),
            new Reservation("2", new DateTime(2017, 01, 15), new DateTime(2017, 01, 17), "1", 2)
        });
            RoomStatus i;
            try
            {
                i = this.CheckInClientTest(reservationsMock.Object, (string)null);
                Assert.Fail("Out of range");
            }
            catch (Exception)
            {

            }
        }

[TestMethod]
[PexGeneratedBy(typeof(ReservationsTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void CheckInClientTest0()
{
            Mock<IReservations> reservationsMock = new Mock<IReservations>();
            reservationsMock.Setup(m => m.AllReservations).Returns(new Reservation[] {
            new Reservation("0", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "3", 2),
            new Reservation("1", new DateTime(2017, 01, 12), new DateTime(2017, 01, 14), "2", 4),
            new Reservation("2", new DateTime(2017, 01, 15), new DateTime(2017, 01, 17), "1", 2)
        });
    RoomStatus i;
    i = this.CheckInClientTest(reservationsMock.Object, "0");
    Assert.AreEqual(i,RoomStatus.Occupied);
}
    }
}
