using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Antra
{
  class Program
  {
    static void Main(string[] args)
    {
      //Antra uzduotis
      int geltona = 0;
      int zalia = 0;
      int raudona = 0;
      int count = 0;
      var streamR = File.OpenText("U2.txt");
      for (int i = int.Parse(streamR.ReadLine()); i > 0; i--)
      {
        var str = streamR.ReadLine();
        switch (str.First())
        {
          case 'G':
            geltona += int.Parse(str.Substring(1));
            break;
          case 'Z':
            zalia += int.Parse(str.Substring(1));
            break;
          case 'R':
            raudona += int.Parse(str.Substring(1));
            break;
          default:
            break;
        }
      }
      count = geltona;
      if (zalia < count) count = zalia;
      if (raudona < count) count = raudona;
      count /= 2;
      File.WriteAllLines("U2rez.txt", new string[] { "" + count, "G = " + (geltona - count*2), "Z = " + (zalia - count*2), "R = " + (raudona - count*2) });
    }
  }
}
