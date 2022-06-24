namespace CatchTheAce;

public class UI
{
    public int GetUserInput()
    {
        Console.WriteLine("CATCH THE ACE PROGRAM");
        int yearsToSim;

        bool checkUserInputValid;
        do
        {
            Console.WriteLine("How many years would you like to simulate? ");
            checkUserInputValid = int.TryParse(Console.ReadLine(), out yearsToSim);
            checkUserInputValid = checkUserInputValid && yearsToSim > 0;

            if (yearsToSim >= 1)
            {
                continue;
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("\nPlease enter an integer greater than 0 \n");
            Console.ResetColor();
        }
        while (!checkUserInputValid);

        return yearsToSim;
    }

    public void DisplayResults(int yearsToSimulate, int aceInTheLastWeekCount, List<int> weeksWithFoundAce)
    {
        for (int i = 0; i < weeksWithFoundAce.Count; i++)
        {
            if (weeksWithFoundAce[i] == 51)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Year {i + 1}: ACE OF SPADES FOUND IN THE LAST WEEK!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"Year {i + 1}: Ace of Spades found on Week: {weeksWithFoundAce[i] + 1}");
                Console.ResetColor();
            }
        }

        var inTheLastWeekCount = (aceInTheLastWeekCount / (float)yearsToSimulate) * 100;

        Console.WriteLine($"\nIn {yearsToSimulate} years, the Ace of Spades was found on the last week {aceInTheLastWeekCount} times. " +
                          $"Percentage: {inTheLastWeekCount}%");
    }
}