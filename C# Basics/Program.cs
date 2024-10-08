// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

//
// A console application that asks the user to enter an operator (+-*/),
// and then asks the user to enter 2 numbers.
// The application should perform the operation on the 2 numbers and output the result.

Console.Write("Enter an operator (+ - / *): ");
var key = Console.ReadKey();
Console.WriteLine();

// TODO - Ask the user to enter 2 numbers
// Hint: use int.Parse to store the numbers as integers.

// TODO - define a variable to store the result
switch (key.KeyChar)
{
    case '*':
        Console.WriteLine("multiply");
        // TODO - implement multiplication
        break;
    // TODO - add extra "case" statements for other operators
    default:
        Console.Error.WriteLine("Unknown Operator '{0}'", key.KeyChar);
        break;
}


//
// TODO - output the calculation and the result e.g. "3 * 8 = 24"
// Hint: use a format string similar to above