using System;

namespace CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
double num1 = 0;
double num2 = 0;
double result = 0;
            
Console.WriteLine("----------");
Console.WriteLine("Calculator Program");
Console.WriteLine("-----------");

Console.Write ("Enter num 1: ");
num1 = Convert.ToDouble(Console.ReadLine());
            
Console.Write ("Enter num 2: ");
num2 = Convert.ToDouble(Console.ReadLine());
    
Console.WriteLine("Enter an operation");
Console.WriteLine("\t+ : Add");
Console.WriteLine("\t- : Subtract");
Console.WriteLine("\t* : Multiply");
Console.WriteLine("\t/ : Divide");

switch (Console.ReadLine())
{
    case "+":
        result = num1 + num2;
        Console.WriteLine("$Your result is: {num1} + {num2} = ");
        break;
    case "-":
        result = num1 - num2;
        Console.WriteLine("$Your result is: {num1} - {num2} = ");
        break;
}    
    }
         } 
              }