using HotelProject;
using HotelProject.Model;
using System;
using Microsoft.Pex.Framework;

namespace HotelProject.Model
{
    /// <summary>A factory for HotelProject.Model.Rooms instances</summary>
    public static partial class RoomsFactory
    {
        /// <summary>A factory for HotelProject.Model.Rooms instances</summary>
        [PexFactoryMethod(typeof(Form1), "HotelProject.Model.Rooms")]
        public static void Create()
        {
            Rooms rooms = new Rooms();
            //return rooms;

            // TODO: Edit factory method of Rooms
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
