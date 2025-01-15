namespace Mission2;

public class RollDice
{
    private int rolls;
    private double[] array;
    private string[] array2;
    // constructor
    public RollDice(int temp)
    {
        // assign temp variable the passed in value
        rolls = temp;
        array = new double[13];
        array2 = new string[100];
    }
    
    // method to roll the dice
    public double[] Roll()
    {
        // create arrays and declare variables
        var rand = new Random();
        int randomNum1;
        int randomNum2;
        int totalNum = 0;
        
        // for loop to roll the dice and add the rolls together to get the total roll and store to an array
        for (int num = 0; num <= rolls - 1; num++)
        {
            randomNum1 = rand.Next(1,7);
            randomNum2 = rand.Next(1,7);
            totalNum = randomNum1 + randomNum2;
            array[totalNum] += 1;
        }

        return array;
    } 
    // method to roll the dice
    public void DisplayRollResults(double[] array)
    {
        // output the text for the final output
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1% of the total number of rolls.\nTotal number of rolls = " + rolls + " .");

        // for loop to calculate the percentages
        for (int num = 2; num <= array.Length - 1; num++)
        {
            array[num] = (array[num] / rolls) * 100;
            for (int num2 = 0; num2 < array[num]; num2++)
            {
                array2[num] += "*";
            }
            Console.WriteLine(num + ": " + array2[num] + "\n");
        }
    }
}