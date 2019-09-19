using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLybrary
{
  public  class Car:BaseClass
  {
      public string Licenseplate;
      public DateTime Date;

      public double CarPrice240()
      {
          double price = Price;
          return price = 240;
      }

      public string VehicleTypeForCar()
      {
          string vehicletype = Vehicle;
          return vehicletype="Car";
      }
  }
}
