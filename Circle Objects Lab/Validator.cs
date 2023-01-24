using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects_Lab
{
  public class Validator
  {
    //static objects don't make an object it just calls a class.
    public static double GetUserNumber()
    {
      double result = 0;
      Console.WriteLine("Please enter a number.");

      while (!double.TryParse(Console.ReadLine(), out result)) //could also take away '!' and just put == false after the first ) afdtrer result
      {
        Console.WriteLine("Invalid Input. Try again");
      }

      return result;
    }
  }
}
