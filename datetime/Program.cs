using System;
namespace DatesAndTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // DateTime myValue = DateTime.Now;
            // Console.WriteLine(myValue.ToString());
            // Console.WriteLine(myValue.ToShortDateString());
            // Console.WriteLine(myValue.AddDays(3).ToLongDateString());
//           DateTime myBirthDay = new DateTime(1998, 9, 8);
// DateTime today = DateTime.Now;

// TimeSpan difference = today - myBirthDay;

// Console.WriteLine(difference.TotalDays);

      string employeeID = "John";
      DateTime checkIn  = DateTime.Now;
      Console.WriteLine($"{employeeID}: has checked in at {checkIn}");
       DateTime checkOut  = DateTime.Now;
       TimeSpan workedHours = checkOut - checkIn;
        Console.WriteLine($"{employeeID}: checked out at  {checkOut} Hours");
       Console.WriteLine($"{employeeID}: has worked for  {workedHours} Hours");\
       DateTime today = DateTime.Today;

DateTime lastDay =
    new DateTime(
        today.Year,
        today.Month,
        DateTime.DaysInMonth(
            today.Year,
            today.Month));

   





        }
    }
}