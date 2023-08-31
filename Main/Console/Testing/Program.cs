// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

TimeZoneInfo localTimeZone = TimeZoneInfo.Local;

// Define the target time zone (South Africa Standard Time)
TimeZoneInfo saTimeZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");

// Get the current local time
DateTime localTime = DateTime.Now;

// Convert the local time to South Africa time
DateTime saTime = TimeZoneInfo.ConvertTime(localTime, localTimeZone, saTimeZone);



Console.WriteLine("Hello, World!");
