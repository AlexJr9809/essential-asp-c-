using System.Globalization;

string testStr;
DateTime d1;
DateTime now = DateTime.Now;
TimeSpan diff;
int noOfDays;
do
{
    Console.WriteLine("How Many Days??");
    Console.WriteLine("Enter the date or exit to quit: ");
    testStr = Console.ReadLine();
    DateOnly N1 = DateOnly.FromDateTime(now);
    if (DateTime.TryParse(testStr, out d1))
    {
        DateOnly D1 = DateOnly.FromDateTime(d1);
        if ((now > d1) && D1 != N1)
        {
            diff = (now.Date).Subtract(d1.Date);
            noOfDays = diff.Days;
            if (noOfDays > 1)
            {
                Console.WriteLine($"Chosen Date: {d1:d}");
                Console.WriteLine($"Your chosen date is {noOfDays} days before {now:d}!");
            }
            else
            {
                Console.WriteLine($"Chosen Date: {d1:d}");
                Console.WriteLine($"Your chosen date is {noOfDays} day before {now:d}!");
            }

        }
        else if (d1 > now)
        {
            diff = (d1.Date).Subtract(now.Date);
            noOfDays = diff.Days;
            if (noOfDays > 1)
            {
                Console.WriteLine($"Chosen Date: {d1:d}");
                Console.WriteLine($"Your chosen date is {noOfDays} days after {now:d}!");
            }
            else
            {
                Console.WriteLine($"Chosen Date: {d1:d}");
                Console.WriteLine($"Your chosen date is {noOfDays} day after {now:d}!");
            }
        }
        else if (D1 == N1)
        {
            Console.WriteLine($"Chosen Date: {d1:d}");
            Console.WriteLine($"Your chosen date is Today!");
        }

    }
    else if (testStr == "exit")
    {
        Console.WriteLine("Thank you for your time. Goodbye!");
    }
    else
    {
        Console.WriteLine($"'{testStr}' is an invalid entry or in invalid format");
    }

} while (testStr != "exit");