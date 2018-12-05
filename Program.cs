using System;

namespace Treehouse.FitnessFrog
{
	class Program 
	{
		static void Main()
		{
			var runningTotal = 0.0;

			while(true)
			{
				// Enter the amount of minutes exercised.
				Console.Write("Enter how many minutes you exercised or type \"quit\" to exit: ");
				string entry = Console.ReadLine();

				// If the user types quit then exit the program.
				if(entry.ToLower() == "quit")
				{
					break;
				}

				try
				{
					// Change the entry to valid input.
					var minutes = double.Parse(entry);

					// Give the user some feedback.
					if(minutes <= 0)
					{
						Console.WriteLine("You must enter a value greater than 0.");
						continue;
					}
					else if(minutes <= 10)
					{
						Console.WriteLine("Better than nothing, am I right?");
					}
					else if(minutes <= 30)
					{
						Console.WriteLine("Way to go hot stuff!");
					}
					else if(minutes <= 60)
					{
						Console.WriteLine("You must be a ninja warrior in training!");
					}
					else
					{
						Console.WriteLine("Okay, now you're just showing off!");
					}

					// Add that to a running total.
					runningTotal += minutes;
				}
				catch(FormatException)
				{
					Console.WriteLine("That is invalid input.");
					continue;
				}

				// Show the total to the user.
				Console.WriteLine("You have exercised " + runningTotal + " minutes.");
			}

			// Say goodbye to the user and show the total they entered.
			Console.WriteLine("Goodbye! You entered a total of " + runningTotal + " minutes.");
		}
	}
}