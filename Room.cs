using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLibrary
{
    public class Room
    {
        public int RoomNr { get; set; }
        public char Types { get; set; }
        public double Pris { get; set; }
        public int Hotel_No { get; set; }

        public Room()
        {
        }

        public Room(int roomnr, char types, double pris, int hotelNo)
        {
            RoomNr = roomnr;
            Types = types;
            Pris = pris;
            Hotel_No = hotelNo;
        }


        public override string ToString()
        {
            return $"RoomNo = {RoomNr}, HotelNo = {Hotel_No}, Types = {Types}, Pris = {Pris}";
        }
    }
}
