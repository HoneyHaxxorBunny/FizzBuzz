using System;

public class FizzBuzz
{
	// prints FizzBuzz according to a range 
	// the range specify by the parameters min, max
	public void printFizzBuzz(int min, int max)
	{
		string message = "";
		bool conditionBuzz = false;
		bool conditionFizz = false;
		for (int i = min; i <= max; i++)
		{
			conditionBuzz = i % 5 == 0;
			conditionFizz = i % 3 == 0;
			if (conditionFizz || conditionBuzz)
			{
				if (conditionFizz && conditionBuzz)
				{
					message = "FizzBuzz";
				}
				else if (conditionBuzz)
				{
					message = "Buzz";
				}
				else
				{
					message = "Fizz";
				}

				Console.WriteLine(i + " - " + message); 
			}
			else
			{
				Console.WriteLine(i); 
			}
		}
	}

	public static void Main()
	{
		Program referenceToFizz = new Program();
		referenceToFizz.printFizzBuzz(1, 100);
	}
}
