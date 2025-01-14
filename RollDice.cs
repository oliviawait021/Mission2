namespace Mission2;

public class RollDice
{
    private int rolls;
    public RollDice(int temp)
    {
        rolls = temp;
    }
    // constructor if numRolls isn't passed in

    // method to roll the dice
    public void Roll()
    {
        var rand = new Random();
        float[] array = new float[13];
        string[] array2 = new string[100];
        int randomNum1;
        int randomNum2;
        int totalNum = 0;
        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + rolls + " .");
        for (int num = 0; num <= rolls - 1; num++)
        {
            randomNum1 = rand.Next(1,7);
            randomNum2 = rand.Next(1,7);
            totalNum = randomNum1 + randomNum2;
            array[totalNum] += 1;
        }

        for (int num = 2; num <= array.Length - 1; num++)
        {
            array[num] = (array[num] / rolls) * 100;
            for (int num2 = 0; num2 < array[num]; num2++)
            {
                array2[num] += "*";
            }
            Console.WriteLine( num + ": " + array2[num] + "\n");
        }
        
        
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        
    }
}