# IsDateBefore
A simple program that determines if the first date is before the second date.
This example uses .NET Core 2.2 (just for the heck of it!)

Usage examples: 

http://localhost:4649/api/Date?year1=1970&month1=10&day1=28&year2=1970&month2=12&day2=31 (returns true)
http://localhost:4649/api/Date?year1=1970&month1=10&day1=28&year2=1970&month2=10&day2=26 (returns false)
http://localhost:4649/api/Date?year1=1970&month1=10&day1=28&year2=1970&month2=10&day2=28 (returns false --> equal dates)
