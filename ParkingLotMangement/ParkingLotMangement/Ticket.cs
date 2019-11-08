using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotMangement
{
    //public class Ticket_old
    //{
    //    public static int ticketnumber;
    //    public string vehicle_number, vehicle_type;
    //    public int slot_number;
    //    public DateTime intime, outtime;
    //    public Ticket_old(string vehicletype, string vehiclenumber, int slotnumber)
    //    {
    //        vehicle_number = vehiclenumber;
    //        vehicle_type = vehicletype;
    //        slot_number = slotnumber;
    //        intime = DateTime.Now;
    //    }
    //}


    public class Ticket
    {
        private static int increment = 1;
        public int Id { get; set; }
        public string VehicleNumber { get; set; }
        public string SlotNumber { get; set; }
        public Vehicletype VehicleType { get; set; }
        public DateTime InTime { get; set; }
        public DateTime OutTime { get; set; }

        public Ticket(Vehicle vehicle, string slotNumber)
        {
            this.Id = increment++;
            this.InTime = DateTime.UtcNow;
            this.VehicleNumber = vehicle.Number;
            this.SlotNumber= slotNumber;
            this.VehicleType = vehicle.Type;
        }
    }
}
