namespace CatchTheAce;

public class UI 
{

    public int GetUserInput() 
    {
        var prompt = "How many years would you like to simulate? ";
        Console.WriteLine("CATCH THE ACE PROGRAM");
        int yearsToSim;

        bool checkUserInputValid;
        do
        {
            Console.WriteLine(prompt);
            checkUserInputValid = int.TryParse(Console.ReadLine(), out yearsToSim);
            checkUserInputValid = checkUserInputValid && yearsToSim > 0;

            if (yearsToSim<1)
            {
                Console.WriteLine("\nPlease enter an integer greater than 0 \n", Console.ForegroundColor = ConsoleColor.DarkYellow);
                Console.ResetColor();
            }
        }
        while (!checkUserInputValid);
        return yearsToSim;

    }

    public void DisplayResults() 
    {
        for (int i = 0; i < Results.WeeksWhereAceWasFound.Count; i++) 
        { 
            if(Results.WeeksWhereAceWasFound[i] == 51)
            {
                Console.WriteLine($"Year {i+1}: ACE OF SPADES FOUND IN THE LAST WEEK!", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Year {i+1}: Ace of Spades found on Week: {Results.WeeksWhereAceWasFound[i] + 1}", Console.ForegroundColor = ConsoleColor.DarkCyan);
                Console.ResetColor();
            }
        }
        Console.WriteLine($"\nIn {Program.YearsToSimulate} years, the Ace of Spades was found on the last week {Program.AceInTheLastWeekCount} times. Percentage: {(Program.AceInTheLastWeekCount / (float)Program.YearsToSimulate)*100}%");
    }
}