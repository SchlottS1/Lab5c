using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number to see if it's prime");
    double input = Convert.ToDouble(Console.ReadLine());
    for (double i = input - 1; i > 1; i--)
    {
    double denominator = i;
    double result = input % denominator;
    if (result == 0)
     {
      break;
     }
     Console.WriteLine("This isn't a prime number");
    } Console.WriteLine ("This is a prime number");
  } 
}