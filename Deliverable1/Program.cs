using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            string vacationType = "";
            int groupSize = 0;
            string result = "";
            string travelType = "";
            string destination = "";
            Boolean valid = false;
            
            while (!valid)
            {
                Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous?");
                vacationType = Console.ReadLine().ToLower();
                if (vacationType == "musical")
                {
                    valid = true;
                    destination = "New Orleans";
                    break;
                }
                else if (vacationType == "tropical")
                {
                    valid = true;
                    destination = "a beach in Mexico";
                    break;
                }
                else if (vacationType == "adventurous")
                {
                    valid = true;
                    destination = "whitewater raft the Grand Canyon";
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.\n");
                }

            }
            valid = false;
            while (!valid) 
            { 
                Console.WriteLine("\nHow many are in your group?");
                try
                {
                    groupSize = int.Parse(Console.ReadLine());
                    if (groupSize > 0)
                    {
                        valid = true;
                    }
                    else if (groupSize == 0)
                    {
                        Console.WriteLine("Input cannot be 0.");
                    }
                    else
                    {
                        Console.WriteLine("Input cannot be less than 0.");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Please enter a whole number.");
                }
            }


            if (groupSize > 0)
            {
                if (groupSize >= 6)
                {
                    travelType = "charter a flight";
                }
                else if (groupSize >= 3 && groupSize < 6)
                {
                    travelType = "take a helicopter";
                }
                else
                {
                    travelType = "fly first class";
                }
                result = "\nSince you're a group of " + groupSize + " going on a " + vacationType + " vacation, you should " + travelType + " to " + destination;

            }
            Console.WriteLine(result);
            return;
        }
    }
}
