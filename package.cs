using System;

namespace FastTrackShipping
{
    class Program
    {
        static void Main(string[] args)
        {
            ShippingEstimate();
        }

        static void ShippingEstimate()
        {
            Console.WriteLine("Greetings from FastTrack Shipping! Please follow the steps below.");

            // Get the weight of the package
            Console.Write("Enter the weight of your package (lbs): ");
            double packageWeight = double.Parse(Console.ReadLine());

            // Check if the package exceeds the weight limit
            if (packageWeight > 50)
            {
                Console.WriteLine("Sorry, your package exceeds the weight limit for FastTrack Shipping. Have a great day!");
                return;
            }

            // Get package dimensions
            Console.Write("Enter the width of your package (inches): ");
            double packageWidth = double.Parse(Console.ReadLine());

            Console.Write("Enter the height of your package (inches): ");
            double packageHeight = double.Parse(Console.ReadLine());

            Console.Write("Enter the length of your package (inches): ");
            double packageLength = double.Parse(Console.ReadLine());

            // Verify if total dimensions exceed the allowed size
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Unfortunately, your package is too large for FastTrack Shipping.");
                return;
            }

            // Calculate the shipping cost
            double shippingCost = (packageWidth * packageHeight * packageLength * packageWeight) / 100;

            // Display the estimated shipping cost
            Console.WriteLine($"The estimated shipping cost for your package is: ${shippingCost:F2}");
            Console.WriteLine("We appreciate your business!");
        }
    }
}
