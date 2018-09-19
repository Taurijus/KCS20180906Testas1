using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Trecia
{

  class Program
  {
    static void Main()
    {
      Console.WriteLine("Įveskite skaičių masyvą");
      var masyvas = Console.ReadLine();
      var numbers = masyvas.Split(' ').Select(Int32.Parse).ToList();
      Console.WriteLine("Įveskite kokią sumą reikią surinkti");
      int suma = Convert.ToInt32(Console.ReadLine());

      var kiekKartu = 0;
      
      
      }
          
      
     // Console.ReadLine();


    }
  }

