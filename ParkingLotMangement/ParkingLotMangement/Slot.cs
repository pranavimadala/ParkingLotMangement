using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLotMangement
{
    public class Slot_old
    {
        public static int no_of_twowheeler_slots, no_of_fourwheeler_slots, no_of_heavywheeler_slots;
      public  Vehicle vehicle=new Vehicle();
      public  Slot_old[] twowheeler_slots = new Slot_old[no_of_twowheeler_slots];
       public Slot_old[] fourwheeler_slots = new Slot_old[no_of_fourwheeler_slots];
       public Slot_old[] heavywheeler_slots = new Slot_old[no_of_heavywheeler_slots];
    }


    public class Slot
    {
        public int Id { get; set; }
        public string SlotNumber { get; set; }
        public Vehicletype SlotType { get; set; }
        public Vehicle Vehicle { get; set; }

        public bool IsAvailable
        {
            get
            {
                return this.Vehicle == null;
            }
        }

        public Slot(int id, Vehicletype slotType)
        {
            this.Id = id;
            this.SlotType = slotType;
        }
    }
}
