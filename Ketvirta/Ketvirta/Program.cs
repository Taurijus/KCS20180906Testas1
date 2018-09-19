using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketvirta
{
  class Program
  {
    static void Main()
    {

      bool OutPut(string zodis)
      {
        int puseZodzio = (zodis.Length / 2);
        string pirmaPuse = zodis.Substring(0, puseZodzio);
        char[] array = zodis.ToCharArray();

        Array.Reverse(array);

        string temp = new string(array);
        int tempLenght = (temp.Length / 2);
        string antraPuse = temp.Substring(0, tempLenght);

        return pirmaPuse.Equals(antraPuse);
      }

      Console.WriteLine("Įveskite žodį");
      while (true)
      {
        var ivestasZodis = Console.ReadLine();
        var arYra = OutPut(ivestasZodis);
        Console.WriteLine(arYra);
        
      }


    }
  }
}
