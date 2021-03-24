using System;

namespace TimeCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter a number of seconds: ");
            int input = Convert.ToInt32(Console.ReadLine());


            int minutes = input / 60;
            int hours = input / 3600;
            int days = input / 86400;




            if (input >= 60 && input <= 3599)
            {
                Console.WriteLine("there are " + minutes + " minutes and " + input % 60 + " seconds.");
            }

            else if (input >= 3600 && input <= 86399)
            {

                Console.WriteLine("there are " + input / 3600 + " hours " + minutes % 60 + " minutes and " + input % 60 + " seconds.");
            }

            else
            {
                Console.WriteLine("there are " + days + " days, " + hours % 24 + " hours, " + minutes % 60 + " minutes and " + input % 60 + " seconds.");
            }
        }
    }
}
