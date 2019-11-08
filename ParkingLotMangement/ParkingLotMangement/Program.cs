using System;

namespace ParkingLotMangement
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice,vehicletype;
            string vehiclenumber;
            SlotMangement slotmangemnet = new SlotMangement();
            Console.WriteLine("Enter the details\nEnter the total number of twowheeler vehicles\n");
            Slot_old.no_of_twowheeler_slots = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the total number of fourwheeler vehicles\n");
            Slot_old.no_of_fourwheeler_slots = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the total number of heavywheeler vehicles:\n");
          
                Slot_old.no_of_heavywheeler_slots = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the choice \n1.See the parking details\n2.Park the vehicle\n3.Unpark the vehicle\n4.Exit\n");
            choice= Convert.ToInt32(Console.ReadLine());
            while (choice != 4)
            {
                switch (choice)
                {
                    case 1:
                        {
                            slotmangemnet.ParkingsDetails();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter the vehicle number");
                            vehiclenumber = Console.ReadLine();
                            Console.WriteLine("Enter the vehicle type\n1.Two wheeler\n2.Four Wheeler\n3.Heavy Wheeler\n");
                            vehicletype = Convert.ToInt32(Console.ReadLine());
                            slotmangemnet.ParkingVehicle(vehicletype, vehiclenumber);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter the vehicle number");
                            vehiclenumber = Console.ReadLine();
                            Console.WriteLine("Enter the vehicle type\n1.Two wheeler\n2.Four Wheeler\n3.Heavy Wheeler\n");
                            vehicletype = Convert.ToInt32(Console.ReadLine());
                           slotmangemnet.UnparkingVehicle(vehiclenumber, vehicletype);
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Entered choice is wrong");
                            break;
                        }
                }
                 Console.WriteLine("Enter the choice \n1.See the parking details\n2.Park the vehicle\n3.Unpark the vehicle\n4.Exit\n");
            choice= Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
