using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace projecto.webAPI.Helpers
{
    public  static class DateTimeExtensions
    {
       public static int GetCurrentAge(this DateTime dateTime)
       {
            var currentDate =DateTime.UtcNow;
            int age = currentDate.Year - dateTime.Year;

            if (currentDate < dateTime.AddYears(age))
        
                age --;

            return age;
        
       } 
    }
}