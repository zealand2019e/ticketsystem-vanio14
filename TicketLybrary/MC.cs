using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLybrary
{
   public class MC:BaseClass
    {
        public double Price125kr()
        {
            double price = Price;
            return price=125;
        }

        public string MCVehicle()
        {
            string vehicle = Vehicle;
            return vehicle="MC";
        }
    }
}
