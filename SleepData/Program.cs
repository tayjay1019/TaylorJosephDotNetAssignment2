﻿using System;
using System.IO;

namespace SleepData
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // ask for input
            Console.WriteLine("Enter 1 to create data file.");
            Console.WriteLine("Enter 2 to parse data.");
            Console.WriteLine("Enter anything else to quit.");
            // input response
            string resp = Console.ReadLine();

            // specify path for data file
            // string file = "/users/jgrissom/downloads/data.txt";
            string file = AppDomain.CurrentDomain.BaseDirectory + "data.txt";

            if (resp == "1")
            {
                // create data file

                // ask a question
                Console.WriteLine("How many weeks of data is needed?");
                // input the response (convert to int)
                int weeks = int.Parse(Console.ReadLine());

                // determine start and end date
                DateTime today = DateTime.Now;
                // we want full weeks sunday - saturday
                DateTime dataEndDate = today.AddDays(-(int)today.DayOfWeek);
                // subtract # of weeks from endDate to get startDate
                DateTime dataDate = dataEndDate.AddDays(-(weeks * 7));

                // random number generator
                Random rnd = new Random();

                // create file
                StreamWriter sw = new StreamWriter(file);
                // loop for the desired # of weeks
                while (dataDate < dataEndDate)
                {
                    // 7 days in a week
                    int[] hours = new int[7];
                    for (int i = 0; i < hours.Length; i++)
                    {
                        // generate random number of hours slept between 4-12 (inclusive)
                        hours[i] = rnd.Next(4, 13);
                    }
                    // M/d/yyyy,#|#|#|#|#|#|#
                    //Console.WriteLine($"{dataDate:M/d/yy},{string.Join("|", hours)}");
                    sw.WriteLine($"{dataDate:M/d/yyyy},{string.Join("|", hours)}");
                    // add 1 week to date
                    dataDate = dataDate.AddDays(7);
                }
                sw.Close();
            }
            else if (resp == "2")
            {
                // TODO: parse data file
                StreamReader sr = new StreamReader(file);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    String[] arr = line.Split(',');
                    Console.WriteLine("Week of " + "{0}", DateTime.Parse(arr[0]).ToString("MMM dd, yyyy"));
                    String[] nums = arr[1].Split('|');
                    int total = Int32.Parse(nums[0]) + Int32.Parse(nums[1]) + Int32.Parse(nums[2]) + Int32.Parse(nums[3]) + Int32.Parse(nums[4]) + Int32.Parse(nums[5]) + Int32.Parse(nums[6]);
                    double avg = total / 7.0;
                    Console.WriteLine("Su Mo Tu We Th Fr Sa Tot Avg\n-- -- -- -- -- -- -- --- ---");
                    Console.WriteLine("{0,2} {1,2} {2,2} {3,2} {4,2} {5,2} {6,2} {7,3} " + $"{avg:n1}", nums[0], nums[1], nums[2], nums[3], nums[4], nums[5], nums[6], total);
                    Console.WriteLine();

                }
                sr.Close();

            }
        }
    }
}
