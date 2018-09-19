using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Penkta
{
  class Program
  {
    static void Main(string[] args)
    {
      //Penkta uzduotis
      var str = Console.ReadLine();
      string[] aStr = str.Split(' ');
      List<string> lStrAts = new List<string>();
      lStrAts = aStr.ToList<string>();
      //Sukam cikla blogiausiai imanomai situacijai kai skaiciai isdelioti atvirksciai
      for (int z = 0; z < aStr.Length-1; z++)
      {
        for (int i = 0; i < aStr.Length - 1; i++)
        {
          //Jai skaiciu kombinacija ab maziau uz ba skaicius apkeiciam vietom
          if (!abDaugiauNeiBa(lStrAts[i], lStrAts[i + 1]))
          {
            var tmpstr = lStrAts[i + 1];
            lStrAts[i + 1] = lStrAts[i];
            lStrAts[i] = tmpstr;
          }
        }
      }
      foreach (var item in lStrAts)
      {
        Console.Write(item);
      }
    }

    //Lygina 2 skaiciu kombinacija True jai ab > ba
    static bool abDaugiauNeiBa(string a, string b)
    {
      var ab = int.Parse(a + b);
      var ba = int.Parse(b + a);
      if (ab > ba) return true;
      return false;
    }
  }
}
