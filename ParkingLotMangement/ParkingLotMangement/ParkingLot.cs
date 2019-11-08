using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotMangement
{
    public class ParkingLot
    {
        public List<Slot> Slots { get; set; }

        public List<Ticket> Tickets { get; set; }

        public ParkingLot()
        {
            this.Slots = new List<Slot>();
        }

        public Slot GetSlot(Vehicletype vehicletype)
        {
            return this.Slots.FirstOrDefault(sl => sl.SlotType == vehicletype && sl.IsAvailable);
        }

        public Ticket Park(Vehicle vehicle)
        {
            var slot = this.GetSlot(vehicle.Type);
            if (slot != null)
            {
                slot.Vehicle = vehicle;

                return new Ticket(vehicle, slot.SlotNumber);
            }

            throw new Exception($"No Space Available for {vehicle.Type}");
        }

        public Ticket GetTicket(int TicketNumber)
        {
            this.Tickets.Where(c => c.VehicleNumber != null).GroupBy(c => c.SlotNumber).SelectMany(c => c.SelectMany(g => g.SlotNumber));
            return this.Tickets.FirstOrDefault(s1 => s1.Id == TicketNumber);
        }
        public bool UnPark(int TicketNumber)
        {
            var ticket = this.GetTicket(TicketNumber);

            if (ticket != null)
            {
                ticket.OutTime = DateTime.UtcNow;
                return true;
            }
            return false;
        }
    }
}
