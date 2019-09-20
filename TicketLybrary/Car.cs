using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLybrary
{
  public  class Car:Vehicle
  {
        public override int Discount()
        {
            throw new NotImplementedException();
        }


        //public string Licenseplate;
        //public DateTime Date;

        /// <summary>
        /// Show Car price
        /// </summary>
        /// <returns></returns>

        public override double Price()
      {
          double price = 240;
          IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
          {
              for (DateTime i = start; i < end; i = i.AddDays((1)))
              {
                  yield return i;
              }

              var weekends = GetDaysBetween(DateTime.Today, DateTime.Today.AddDays(365)).Where(d =>
                  d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday);

          }
            return price = 240 * 0.80;
            return price;
      }

        /// <summary>
        /// Show Car Vehicle type
        /// </summary>
        /// <returns></returns>
      public override string VehicleType()
      {
          return "Car";
      }

  }
}
