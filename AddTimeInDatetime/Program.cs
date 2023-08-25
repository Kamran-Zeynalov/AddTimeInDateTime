using System.Globalization;

namespace AddTimeInDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Enter date in this format: \n dd/MM/yyy hh:mm");
            Console.ForegroundColor = ConsoleColor.White;
            string? user = Console.ReadLine();
            string dateFormat = "dd/MM/yyyy hh:mm";


            var insert = DateTime.ParseExact(user, dateFormat, null);
            insert = insert.AddDays(30);
            insert = insert.AddHours(6);
            insert = insert.AddMinutes(17);
            Console.WriteLine(insert.ToString(dateFormat));


        }
    }
}