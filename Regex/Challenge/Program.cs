using System;
using System.Text.RegularExpressions;
using System.Globalization;


string dateString;
Console.WriteLine("Enter Date in mm/dd/yy format ");
dateString = Console.ReadLine();
string pattern = @"^(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01])/(?:\d{2})?\d{2}$";
Regex regex = new Regex(pattern);

if (!regex.IsMatch(dateString))
    {
        throw new ArgumentException("Invalid date format. Please provide a date in mm/dd/yyyy format.");
    }

string[] dateParts = dateString.Split('/');
int month = int.Parse(dateParts[0]);
int day = int.Parse(dateParts[1]);
int year = int.Parse(dateParts[2]);

Console.WriteLine($"{year:G}-{month:D2}-{day:D2}");


