// See https://aka.ms/new-console-template for more information

using System;
using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        // declare variables
        string stringRolls = "";
        int numRolls = 0;
        
        // get user input and assign it to numRolls variable
        Console.WriteLine("Welcome to the dice throwing simulation!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        stringRolls = Console.ReadLine();
        numRolls = Int32.Parse(stringRolls);
        
        // create new object of roll dice called rd
        RollDice rd;
        rd = new RollDice(numRolls);
        
        // call the Roll() method
        rd.Roll();
    }
}