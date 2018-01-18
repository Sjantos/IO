using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelProject.Model;

using System;

namespace HotelProject.Model.Tests
{
    public partial class ReservationsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(ReservationsTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void CheckInClientTest1()
{
    Reservations reservations;
    RoomStatus i;
    reservations = new Reservations();
    i = this.CheckInClientTest(reservations, (string)null);
    Assert.AreEqual(i, RoomStatus.Occupied);
        }

[TestMethod]
[PexGeneratedBy(typeof(ReservationsTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void CheckInClientTest0()
{
    Reservations reservations;
    RoomStatus i;
    reservations = new Reservations();
    i = this.CheckInClientTest(reservations, "0");
    Assert.AreEqual(i,RoomStatus.Occupied);
}
    }
}
