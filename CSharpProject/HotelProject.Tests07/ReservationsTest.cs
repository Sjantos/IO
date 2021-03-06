using System;
using Hotel.Interfaces;
using HotelProject.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HotelProject.Model.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla Reservations</summary>
    [TestClass]
    [PexClass(typeof(Reservations))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ReservationsTest
    {

        /// <summary>Zastępcza klasa testowa dla CheckInClient(String)</summary>
        [PexMethod]
        internal RoomStatus CheckInClientTest([PexAssumeUnderTest]IReservations target, string reservationID)
        {
            Mock<IRooms> mock = new Mock<IRooms>();
            mock.Setup(m => m.AllRooms).Returns(new Room[] {
                new Room(0, 4, "2x2", RoomStatus.Empty),
                new Room(1, 2, "1x2", RoomStatus.Occupied),
                new Room(2, 3, "1x2+1x1", RoomStatus.Empty),
                new Room(3, 1, "1x1", RoomStatus.Occupied),
                new Room(4, 3, "3x1", RoomStatus.Empty),
                new Room(5, 2, "2x1", RoomStatus.Empty),
                new Room(6, 2, "1x2", RoomStatus.Empty)
            });
            RoomStatus result = target.CheckInClient(reservationID, mock.Object);
            return result;
            // TODO: dodaj asercje do metoda ReservationsTest.CheckInClientTest(Reservations, String)
        }

        /// <summary>Zastępcza klasa testowa dla CheckInClient(String)</summary>
        [PexMethod]
        internal int[] FindFreeRoomTest([PexAssumeUnderTest]IReservations target, DateTime startDate, DateTime endDate, int capacity)
        {
            Mock<IRooms> mock = new Mock<IRooms>();
            mock.Setup(m => m.AllRooms).Returns(new Room[] {
                new Room(0, 4, "2x2", RoomStatus.Empty),
                new Room(1, 2, "1x2", RoomStatus.Occupied),
                new Room(2, 3, "1x2+1x1", RoomStatus.Empty),
                new Room(3, 1, "1x1", RoomStatus.Occupied),
                new Room(4, 3, "3x1", RoomStatus.Empty),
                new Room(5, 2, "2x1", RoomStatus.Empty),
                new Room(6, 2, "1x2", RoomStatus.Empty)
            });
            return target.FindFreeRoom(startDate, endDate, capacity, mock.Object);
            // TODO: dodaj asercje do metoda ReservationsTest.CheckInClientTest(Reservations, String)
        }
    }
}
