using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra
{
  class Program
  {
    public class Struktura
    {
        
      public readonly char raide;
      public int skaicius;

      public Struktura(char raide, int skaicius)
      {
        this.raide = raide;
        this.skaicius = skaicius;
      }

    }
  



  static void Main()
    {
      var stream = new StreamReader(@"U2.txt");
      var kruveliuKiekis = stream.ReadLine();

      var eilutes = stream.ReadToEnd();
      stream.Close();

      var zodziai = eilutes.Split('\n');
      var kiekZodziu = zodziai.Count();

      var spalvosKiekiai = new Dictionary<string, int>(); // SITAM reik splittint key per viduril. R 5 \n B 10 ir pan.
      
     foreach (var zodis in zodziai)
      {
        if (!spalvosKiekiai.ContainsKey(zodis))
        {
          spalvosKiekiai.Add(zodis, 1);
        }
        else
        {
          spalvosKiekiai[zodis]++;
        }
        }

      foreach (var isskiriam in spalvosKiekiai)
      {
        isskiriam.Key.Split(' ');
      }


      Console.ReadLine();
    }
  }
}


