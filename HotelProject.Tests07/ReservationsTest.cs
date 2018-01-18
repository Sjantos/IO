using System;
using HotelProject.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        internal RoomStatus CheckInClientTest([PexAssumeUnderTest]Reservations target, string reservationID)
        {
            RoomStatus result = target.CheckInClient(reservationID);
            return result;
            // TODO: dodaj asercje do metoda ReservationsTest.CheckInClientTest(Reservations, String)
        }
    }
}
