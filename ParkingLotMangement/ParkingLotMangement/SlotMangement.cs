using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ParkingLotMangement
{
    class SlotMangement
    {
        Ticket[] ticket = new Ticket[3000];
        Slot_old slot = new Slot_old();
        public void ParkingsDetails()
        {
             for (int slotnumber = 0; slotnumber <Slot_old. no_of_twowheeler_slots; slotnumber++)
               {
                   if (slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Length != 0)
                   {
                       for (int ticket_number = 0; ticket_number < Ticket.ticketnumber; ticket_number++)
                       {
                           if(slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Equals(ticket[ticket_number].vehicle_number))
                           Console.WriteLine("Slot Number:" + slotnumber + "\nVehcile Number:" + ticket[ticket_number].vehicle_number + "\nVehicleType:" + ticket[ticket_number].vehicle_type + "\nIntime:" + ticket[ticket_number].intime);
                       }

                       }
               }
               for (int slotnumber = 0; slotnumber < Slot_old.no_of_fourwheeler_slots; slotnumber++)
               {
                   if (slot.fourwheeler_slots[slotnumber].vehicle.vehiclenumber.Length != 0)
                   {
                       for (int ticket_number = 0; ticket_number < Ticket.ticketnumber; ticket_number++)
                       {
                           if (slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Equals(ticket[ticket_number].vehicle_number))
                               Console.WriteLine("Slot Number:" + slotnumber + "\nVehcile Number:" + ticket[ticket_number].vehicle_number + "\nVehicleType:" + ticket[ticket_number].vehicle_type + "\nIntime:" + ticket[ticket_number].intime);
                       }
                   }
               }
               for (int slotnumber = 0; slotnumber < Slot_old.no_of_heavywheeler_slots; slotnumber++)
               {
                   if (slot.heavywheeler_slots[slotnumber].vehicle.vehiclenumber.Length != 0)
                   {
                       for (int ticket_number = 0; ticket_number < Ticket.ticketnumber; ticket_number++)
                       {
                           if (slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Equals(ticket[ticket_number].vehicle_number))
                               Console.WriteLine("Slot Number:" + slotnumber + "\nVehcile Number:" + ticket[ticket_number].vehicle_number + "\nVehicleType:" + ticket[ticket_number].vehicle_type + "\nIntime:" + ticket[ticket_number].intime);
                       }
                   }
               }
          }
       public   void ParkingVehicle(int vehicletype, string vehiclenumber)
          {
              if (vehicletype == 1)
              {
                  for (int slotnumber = 1; slotnumber < Slot_old.no_of_twowheeler_slots; slotnumber++)
                  {
                      if (slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Length ==0)
                      {

                          slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber = vehiclenumber;
                          ticket[Ticket.ticketnumber] = new Ticket(Enum.GetName(typeof(Vehicle), vehicletype), vehiclenumber, slotnumber);
                          Ticket.ticketnumber++;
                          break;
                      }
                  }
              }
              else if (vehicletype == 2)
              {
                  for (int slotnumber = 0; slotnumber < Slot_old.no_of_fourwheeler_slots; slotnumber++)
                  {
                      if (slot.fourwheeler_slots[slotnumber].vehicle==null)
                      {

                          slot.fourwheeler_slots[slotnumber].vehicle = new Vehicle();
                          slot.fourwheeler_slots[slotnumber].vehicle.vehiclenumber = vehiclenumber;
                         ticket[Ticket.ticketnumber] = new Ticket(Enum.GetName(typeof(Vehicle), vehicletype), vehiclenumber, slotnumber);
                          Ticket.ticketnumber++;
                      }
                  }
              }
              else if (vehicletype == 3)
              {
                  for (int slotnumber = 0; slotnumber <Slot_old.no_of_heavywheeler_slots; slotnumber++)
                  {
                      if (slot.heavywheeler_slots[slotnumber].vehicle==null)
                      {

                          slot.heavywheeler_slots[slotnumber].vehicle = new Vehicle();
                          slot.heavywheeler_slots[slotnumber].vehicle.vehiclenumber = vehiclenumber;
                          ticket[Ticket.ticketnumber] = new Ticket(Enum.GetName(typeof(Vehicle), vehicletype), vehiclenumber, slotnumber);
                          Ticket.ticketnumber++;
                      }
                  }
              }
          }
        public  void UnparkingVehicle(string vehiclenumber, int vehicletype)
          {
              if (vehicletype == 1)
              {
                  for (int slotnumber = 0; slotnumber < Slot_old.no_of_twowheeler_slots; slotnumber++)
                  {
                      if (slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber.Equals(vehiclenumber))
                      {
                          slot.twowheeler_slots[slotnumber].vehicle.vehiclenumber = null;
                      }
                  }
              }
              else if (vehicletype == 2)
              {
                  for (int slotnumber = 0; slotnumber < Slot_old.no_of_fourwheeler_slots; slotnumber++)
                  {
                      if (slot.fourwheeler_slots[slotnumber].vehicle.vehiclenumber.Length == 0)
                      {
                          slot.fourwheeler_slots[slotnumber].vehicle.vehiclenumber =null;
                      }
                  }
              }
              else if (vehicletype == 3)
              {
                  for (int slotnumber = 0; slotnumber < Slot_old.no_of_heavywheeler_slots; slotnumber++)
                  {
                      if (slot.heavywheeler_slots[slotnumber].vehicle.vehiclenumber.Length == 0)
                      {
                          slot.heavywheeler_slots[slotnumber].vehicle.vehiclenumber = null;
                      }
                  }
              }
          }
      }
  }
            
