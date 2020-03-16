using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime DatoFra { get; set; }
        public DateTime DatoTil { get; set; }
        public Room Room { get; set; }
        public Guest Guest { get; set; }
        public int Hotel_No { get; set; }


        public Booking()
        {
        }

        public Booking(int id, int hotel_No, DateTime datoFra, DateTime datoTil, Room room, Guest guest)
        {
            Id = id;
            Hotel_No = hotel_No;
            DatoFra = datoFra;
            DatoTil = datoTil;
            Room = room;
            Guest = guest;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Hotel_No)}: {Hotel_No}, Room:{Room.ToString()}, {nameof(DatoFra)}: {DatoFra}, {nameof(DatoTil)}: {DatoTil}, Guest: {Guest.ToString()}";
        }
    }
}
