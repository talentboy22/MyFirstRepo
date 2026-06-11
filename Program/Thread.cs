using System;

namespace MyFirsttry
{
    internal static class Program
    {
        private static void Main()
        {
            var now = DateTime.Now;

            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Current time information:");
            Console.WriteLine($"  Local time:   {now:yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"  UTC time:     {now.ToUniversalTime():yyyy-MM-dd HH:mm:ss}");
            Console.WriteLine($"  Day of week:  {now:dddd}");
            Console.WriteLine($"  Time zone:    {TimeZoneInfo.Local.DisplayName}");
        }
    }
}
