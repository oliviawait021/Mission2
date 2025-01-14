// See https://aka.ms/new-console-template for more information

using System;
using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        string stringRolls = "";
        int numRolls = 0;
        
        Console.WriteLine("Welcome to the dice throwing simulation!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        stringRolls = System.Console.ReadLine();
        numRolls = Int32.Parse(stringRolls);
        
        RollDice rd;
        rd = new RollDice(numRolls);
        
        rd.Roll();
    }
}