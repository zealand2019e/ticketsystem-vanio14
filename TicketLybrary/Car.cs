using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLybrary
{
  public  class Car
  {
      public string Licenseplate;
      public DateTime Date;

      public double Price()
      {
          return 240;
      }

      public string VehicleType()
      {
          return "Car";
      }
  }
}
