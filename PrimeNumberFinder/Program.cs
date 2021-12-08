using System;
using Models;

class PrimeNumberProgram
{
  static void Main()
  {
    Console.WriteLine("Type in a number to see all the prime numbers that come beofre it!");
    int userNumber = int.Parse(Console.ReadLine());
    Prime userNumberPrimes = new Prime(userNumber);
    userNumberPrimes.TruePrime();
    for (int index = 2; index < userNumberPrimes.BoolArray.Length-1; index++) 
    {
      if(userNumberPrimes.BoolArray[index])
      {
        Console.WriteLine(index.ToString());
      }
    }
  }
}