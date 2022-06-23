namespace CatchTheAce;

public class UI 
{
    /// <summary>
    /// Outputs a prompt on the console and retrieves user input.
    /// The input represents how many years the user wants to calculate.
    /// </summary>
    /// <returns>an integer representing the user input for the number of years</returns>
    public int GetUserInput() 
    {
        var prompt = "How many years would you like to simulate? ";
        Console.WriteLine("CATCH THE ACE PROGRAM");
        int years;
        //while (true)
        //{
        //    Console.WriteLine(prompt);
        //    string? input;
        //    if ((input = Console.ReadLine()) == null || !int.TryParse(input, out int i) || i < 1)
        //    {
        //        Console.WriteLine("\nPlease enter an integer greater than 0 \n", Console.ForegroundColor = ConsoleColor.DarkYellow);
        //        Console.ResetColor();
        //    }
        //    else
        //    {
        //        return Deck.Years = i;
        //    }
        //}

        bool check;
        do
        {
            Console.WriteLine(prompt);
            check = (int.TryParse(Console.ReadLine(), out years) || years > 0);

            if (check == false)
            {
                Console.WriteLine("Please enter an integer greater than 0");
            }
        }
        while (!check);
        return years;




    }

    /// <summary>
    /// Displays the results for each year (which week the Ace of Spades was found).
    /// After displaying each years results, the percentage of Ace of Spades found in the last week over the years is displayed.
    /// </summary>
    /// <returns>Outputs the results on the console</returns>
    public void DisplayResults() 
    {
        for (int i = 0; i < Results.weeks.Count; i++) 
        { 
            if(Results.weeks[i] == 51)
            {
                Console.WriteLine($"Year {i+1}: ACE OF SPADES FOUND IN THE LAST WEEK!", Console.ForegroundColor = ConsoleColor.Green);
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine($"Year {i+1}: Ace of Spades found on Week: {Results.weeks[i] + 1}", Console.ForegroundColor = ConsoleColor.DarkCyan);
                Console.ResetColor();
            }
        }
        Console.WriteLine($"\nIn {Program.Years} years, the Ace of Spades was found on the last week {Program.AceInTheLastWeekCount} times. Percentage: {(Program.AceInTheLastWeekCount / (float)Program.Years)*100}%");
    }
}