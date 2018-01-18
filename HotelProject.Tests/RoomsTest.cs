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
        internal void ReportNeedForCleaningTest([PexAssumeUnderTest]Rooms target, int roomNumber)
        {
            target.ReportNeedForCleaning(roomNumber);
            // TODO: dodaj asercje do metoda RoomsTest.ReportNeedForCleaningTest(Rooms, Int32)
        }
    }
}
