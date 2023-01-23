using System;
using System.IO;

class NumberTask
{
	static void Main(string[] args)
	{
		int number;
		int sum = 0;
		// Taking number from user
		while (true)
		{
			Console.WriteLine("Proszę podać nr od 10 do 100");
			var input = Console.ReadLine();

			// Check if number is in range
			if (int.TryParse(input, out number) && number >= 10 && number <= 100)
				break;
			else
				Console.WriteLine("Proszę podać nr od 10 do 100");
		}

		for (int i = 1; i <= number; i++)
		{
			if (i % 2 != 0)
			{
				// Sum odd numbers
				sum += i;

				// Saving odd numbers to file
				using (StreamWriter sw = new StreamWriter("log.txt", true))
				{
					sw.WriteLine(i);
				}
			}
		}

		// Displaying the result of summing odd numbers
		Console.WriteLine("Suma liczb nieparzystych: " + sum);
		Console.ReadKey();
	}
}
