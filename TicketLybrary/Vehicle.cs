using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketLybrary
{
   public  abstract class Vehicle
   {
       public string _licens;

       public string Licenseplate
       {
           get => _licens;
           set
           {
               if (value.Length > 7)
               {
                   throw new  Exception ("License plate must be more than 7 charaters ");
               }
               else
               {
                   _licens = value;
               }

           }
       }

       

        public DateTime Date { get; set; }

        //IEnumerable<DateTime> GetDaysBetween(DateTime start, DateTime end)
        //{
        //    for (DateTime i = start; i < end; i = i.AddDays((1)))
        //    {
        //        yield return i;
        //    }

        //    var weekends = GetDaysBetween(DateTime.Today, DateTime.Today.AddDays(365)).Where(d =>
        //        d.DayOfWeek == DayOfWeek.Saturday || d.DayOfWeek == DayOfWeek.Sunday);
            
        //}

        public abstract int Discount();

        public abstract string VehicleType();
       
        public abstract double Price();



   }
}
