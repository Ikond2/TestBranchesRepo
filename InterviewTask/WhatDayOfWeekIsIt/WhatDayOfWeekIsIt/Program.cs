using System;
using System.Collections.Generic;
using System.Linq;

namespace WhatDayOfWeekIsIt
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> daysOfWeek = new Queue<string>(new string[] {"Thursday", "Friday", "Saturday", "Sunday", "Monday", "Tuesday","Weddnesday"});

            
            string dayOfWeek = DateTime.Now.AddDays(1).DayOfWeek.ToString();
            while (daysOfWeek.Peek()!=dayOfWeek)
            {
                daysOfWeek.Enqueue(daysOfWeek.Dequeue());
            }
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            int check = (new DateTime(2022,12,31)- DateTime.Now).Days;
            int check1 = (new DateTime(year,month,day)- DateTime.Now).Days;

            DateTime now = DateTime.Now;
            int currYear = now.Year;
            int currMonth = now.Month;
            int currDay = now.Day;

            long days = 0;

            int years = year - currYear;
            

            if (year>currYear)
            {
                days+=GetDays(currMonth, currYear)-currDay;
                for (int i = currMonth+1; i <= 12; i++)
                {
                    days += GetDays(i, currYear);
                }
            }
            else
            {
                if (month==currMonth)
                {
                    days += day - currDay;
                }
                else
                {
                    days += GetDays(currMonth, currYear) - currDay;
                    for (int i = currMonth + 1; i < month; i++)
                    {
                        days += GetDays(i, currYear);
                    }
                    days += GetDays(month, year) - (GetDays(month, year) - day);
                }
            }

            List<string> dOfWeek = new List<string>(daysOfWeek);
            for (int i = 1; i <= years; i++)
            {
                decimal percent = (days) % 7;
                string dayToChange = dOfWeek[(int)percent+2];
                while (daysOfWeek.Peek() != dayToChange)
                {
                    daysOfWeek.Enqueue(daysOfWeek.Dequeue());
                }
                dOfWeek = daysOfWeek.ToList();
                if (years>0)
                {
                    if (currYear+i%4==0)
                    {
                    days += (years - 1) * 366;

                    }
                    else
                    {
                        days += (years - 1) * 365;
                    }
                }
            }
            if (year>currYear)
            {
                decimal percent = (days) % 7;
                string dayToChange = dOfWeek[(int)percent + 2];
                while (daysOfWeek.Peek() != dayToChange)
                {
                    daysOfWeek.Enqueue(daysOfWeek.Dequeue());
                }
                dOfWeek = daysOfWeek.ToList();
                for (int i = 1; i < month; i++)
                {
                    days += GetDays(i, year);
                }
                days += GetDays(month, year) - (GetDays(month, year) - day);
            }

            decimal d = days % 7;
            if (d%7==0)
            {
                Console.WriteLine(dOfWeek[6]);
            }
            else if (d % 6 == 0)
            {
                Console.WriteLine(dOfWeek[5]);
            }
            else if (d % 5 == 0)
            {
                Console.WriteLine(dOfWeek[5]);
            }
            else if (d % 4 == 0)
            {
                Console.WriteLine(dOfWeek[3]);
            }
            else if (d % 3 == 0)
            {
                Console.WriteLine(dOfWeek[2]);
            }
            else if (d % 2 == 0)
            {
                Console.WriteLine(dOfWeek[1]);
            }
            else if (d % 1 == 0)
            {
                Console.WriteLine(dOfWeek[0]);
            }
        }

        static long GetDays(int month,int year)
        {
            if (month==2)
            {
                if (year%4==0)
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            if (month%2==0)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }
    }
}
