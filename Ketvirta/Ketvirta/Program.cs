using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ketvirta
{
  class Program
  {
    static void Main(string[] args)
    {
      //Ketvirta uzduotis
      //Ivesta eilute issaugom mazosiom raidem
      string str = Console.ReadLine().ToLower();
      //Sukuriam char masyva eilutes dydzio
      char[] strReverseToChar = new char[str.Length];
      //Apverciam eilute i char masyva
      for (int i = 0; i < str.Length; i++)
      {
        strReverseToChar[i] = str[str.Length - i-1];
      }
      //Lyginam pradine eilute su apverstu char masyvu ir isvedam atsakyma
      if (str==new string(strReverseToChar)) Console.WriteLine(true);
      else Console.WriteLine(false);
    }
  }
}
