using HotelProject;
using HotelProject.Model;
using System;
using Microsoft.Pex.Framework;

namespace HotelProject.Model
{
    /// <summary>A factory for HotelProject.Model.Reservations instances</summary>
    public static partial class ReservationsFactory
    {
        /// <summary>A factory for HotelProject.Model.Reservations instances</summary>
        [PexFactoryMethod(typeof(Form1), "HotelProject.Model.Reservations")]
        public static void Create()
        {
            Reservations reservations = new Reservations();

            // TODO: Edit factory method of Reservations
            // This method should be able to configure the object in all possible ways.
            // Add as many parameters as needed,
            // and assign their values to each field by using the API.
        }
    }
}
