using Mission_2_Assignment;

internal class Program
{
    private static void Main(string[] args)
    {
        int NumToRoll;

        Console.WriteLine("Welcome to the dice throwing simulator!\r\n");
        Console.WriteLine("How many dice rolls would you like to simulate?\r\n");

        NumToRoll = int.Parse(Console.ReadLine());

        DiceRoll diceRoll = new DiceRoll();
        int[] rollResult = diceRoll.GetRolls(NumToRoll);

        //Console.WriteLine(string.Join(", ", rollResult));

        decimal[] Percentages = new decimal[13];

        for (int i = 0; i < 13; i++)
        {
            Percentages[i] = Math.Round((decimal)rollResult[i] / NumToRoll * 100, 2);
        }

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.\r\n");
        Console.WriteLine("Total number of rolls = " + NumToRoll + ".\r\n");

        // calculate percentages
        for (int i = 2; i < 13; i++)
        {
            Console.WriteLine(i + ": " + new string('*', (int)Math.Round(Percentages[i])));         

        }

        Console.WriteLine("\r\nThank you for using the dice throwing simulator. Goodbye!\r\n");
    }
}