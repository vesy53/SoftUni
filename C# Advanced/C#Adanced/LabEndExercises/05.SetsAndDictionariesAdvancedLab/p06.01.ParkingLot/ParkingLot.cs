namespace p06._01.ParkingLot
{
    using System;
    using System.Collections.Generic;

    class ParkingLot
    {
        static void Main(string[] args)
        {
            HashSet<string> dataParking = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                string carNumber = tokens[1];

                if (command == "IN")
                {
                    dataParking.Add(carNumber);
                }
                else if (command == "OUT")
                {
                    dataParking.Remove(carNumber);
                }

                input = Console.ReadLine();
            }

            if (dataParking.Count > 0)
            {
                Console.WriteLine(
                    string.Join(Environment.NewLine, dataParking));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
