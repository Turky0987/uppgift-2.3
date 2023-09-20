using System;

namespace CarRentalCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int startFee = 300;
            const int costPerKilometer = 1;
            const int extraDayFee = 500;

            Console.WriteLine("Välkommen till biluthyrningsföretaget!");
            Console.Write("Hur många dagar vill du hyra bilen? ");
            int rentalDays = int.Parse(Console.ReadLine());

            Console.Write("Hur många kilometer vill du köra? ");
            int kilometersDriven = int.Parse(Console.ReadLine());

            int totalCost = startFee + (rentalDays - 1) * extraDayFee + kilometersDriven * costPerKilometer;

            Console.WriteLine($"Total hyra för {rentalDays} dagar och {kilometersDriven} kilometer är: {totalCost} kr");
        }
    }
}
