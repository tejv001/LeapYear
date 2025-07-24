using CheckForLeapYear.Models;
using CheckForLeapYear.Managers;
using System;
class Program
{
    public static void Main(string[] args)
    {
        YearToBeCheckedModel modelObj = new YearToBeCheckedModel(2000);
        CheckIfLeapYearManager managerObj = new CheckIfLeapYearManager();
        bool isLeapYear = managerObj.CheckIfYearIsLeapMethod(modelObj);
        if(isLeapYear)
        {
            Console.WriteLine($"It is a Leap Year");
        }
        else
        {
            Console.WriteLine("It is not a Leap Year");
        }
    }
}