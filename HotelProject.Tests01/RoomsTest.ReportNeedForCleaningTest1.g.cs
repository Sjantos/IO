using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HotelProject.Model;
// <auto-generated>
// Ten plik zawiera testy generowane automatycznie.
// Nie należy ręcznie modyfikować tego pliku.
// 
// Jeśli zawartość tego pliku stanie się nieaktualna, można go usunąć.
// Stanie się tak na przykład wtedy, gdy plik przestanie się kompilować.
// </auto-generated>
using System;

namespace HotelProject.Model.Tests
{
    public partial class RoomsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(RoomsTest))]
public void ReportNeedForCleaningTest1413()
{
    Rooms rooms;
    RoomStatus i;
    rooms = new Rooms();
    i = this.ReportNeedForCleaningTest1(rooms, 0);
    Assert.IsNotNull((object)rooms);
}
    }
}
