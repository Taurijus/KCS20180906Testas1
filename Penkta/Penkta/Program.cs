using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penkta
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Input: ");
      var masyvas = Console.ReadLine();
      var numbers = masyvas.Split(' ').Select(Int32.Parse).ToList();
      var maxSequence = new List<string>();
      var kiekSkaiciu = numbers.Count;

      while (kiekSkaiciu > 0)
      {
        int maxInList = numbers.Max();
        kiekSkaiciu--;
        string maxNumber = maxInList.ToString();
        numbers.Remove(maxInList);
        maxSequence.Add(maxNumber);
      }

      Console.WriteLine("Output: ");
      foreach (var skaicius in maxSequence)
      {
       Console.Write(skaicius);
      }
      
      Console.ReadLine();
    }


    
  }
}
