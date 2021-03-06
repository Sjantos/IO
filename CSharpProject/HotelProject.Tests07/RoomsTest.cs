// <copyright file="RoomsTest.cs">Copyright ©  2017</copyright>
using System;
using HotelProject.Model;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelProject.Model.Tests
{
    /// <summary>Ta klasa zawiera sparametryzowane testy jednostek dla Rooms</summary>
    [PexClass(typeof(Rooms))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class RoomsTest
    {
        /// <summary>Zastępcza klasa testowa dla ReportNeedForCleaning(Int32)</summary>
        [PexMethod]
        internal RoomStatus ReportNeedForCleaningTest([PexAssumeUnderTest]Rooms target, int roomNumber)
        {
            RoomStatus result = target.ReportNeedForCleaning(roomNumber);
            return result;
            // TODO: dodaj asercje do metoda RoomsTest.ReportNeedForCleaningTest(Rooms, Int32)
        }
        /// <summary>Zastępcza klasa testowa dla ReportExecutionOfRepair(Int32, Boolean)</summary>
        [PexMethod]
        internal RoomStatus ReportExecutionOfRepairTest(
            [PexAssumeUnderTest]Rooms target,
            int roomNumber,
            bool occupied
        )
        {
            RoomStatus result = target.ReportExecutionOfRepair(roomNumber, occupied);
            return result;
            // TODO: dodaj asercje do metoda RoomsTest.ReportExecutionOfRepairTest(Rooms, Int32, Boolean)
        }
    }
}
