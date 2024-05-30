using System;

class Program
{
    static void ChickenBreastCalculator()
    {
        while (true)
        {
            // Give option on which price to set for the chicken
            Console.Write("Type 1 for 13 lari per kilogram, type 2 to set a custom price per kilogram: ");
            string option = Console.ReadLine();

            if (int.TryParse(option, out int choice))
            {
                double pricePerKg;
                if (choice == 1)
                {
                    pricePerKg = 13.0;
                }
                else if (choice == 2)
                {
                    while (true)
                    {
                        Console.Write("Set price per kilogram (lari): ");
                        string input = Console.ReadLine();

                        // Try to parse the input to a double
                        if (double.TryParse(input, out pricePerKg) && pricePerKg > 0)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option. Please enter a valid option.");
                    continue;
                }

                double lari;
                while (true)
                {
                    Console.Write("Lari: ");
                    string input = Console.ReadLine();

                    // Try to parse the input to a double
                    if (double.TryParse(input, out lari) && lari > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number greater than 0.");
                    }
                }

                double grams = lari / pricePerKg;
                double bonelessChicken = Math.Round(grams - (grams * 0.2), 3);
                double proteinAmount = bonelessChicken * 310;
                double dailyProteinNeeds = 110;
                double proteinLeftForTomorrow = proteinAmount - dailyProteinNeeds;
                double percentageOfLeftoverProtein = (proteinLeftForTomorrow / proteinAmount) * 100;

                Console.WriteLine("Boneless Chicken: " + bonelessChicken + " KG");
                Console.WriteLine("Amount of Protein: " + proteinAmount + " grams");
                Console.WriteLine("Amount of Protein left for tomorrow: " + proteinLeftForTomorrow + " grams");
                Console.WriteLine("Percentage of leftover protein for tomorrow: " + Math.Round(percentageOfLeftoverProtein, 3) + "%");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please enter a valid option.");
            }
        }
    }

    static void Main(string[] args)
    {
        ChickenBreastCalculator();
        Console.ReadKey();
    }
}
