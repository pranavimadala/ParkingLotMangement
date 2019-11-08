using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotMangement
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public Vehicletype Type { get; set; }
    }

    public enum Vehicletype
    {
        TwoWheeler = 1,
        FourWheeler = 2,
        HeavyWheeler = 3
    }
}
