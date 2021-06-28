using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a number to see if it's prime");
    int input = Convert.ToInt32(Console.ReadLine());
   for (int i = input - 1; i > 0; i--)
    {
    int denominator = i;
    int result = input % denominator;
    if (i == 1)
     {
      Console.WriteLine("This is a prime number");
      break;
     } else if (result == 0)
     {
       Console.WriteLine("This isn't a prime number");
       break;
     }
    } 
  } 
}