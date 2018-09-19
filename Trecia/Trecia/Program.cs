using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trecia
{
  class Program
  {
    static int count = 0;//Variantu skaicius
    static int rezultatas;//Suma kuria meginam gauti
    static List<string> ats = new List<string>();//Atsakymu sarasas
    static int atsIndex = 0;//atsakymu rusiavimo indexas

    static void Main(string[] args)
    {
      //Uzduotis trecia
      //ivedama skaiciu eilute ir paverciami int masyvu
      var str = Console.ReadLine();
      string[] strA = str.Split(' ');
      int[] intA = new int[strA.Length];
      for (int i = 0; i < intA.Length; i++)
        intA[i] = int.Parse(strA[i]);
      //ivedama norima suma - rezultatas
      var suma = int.Parse(Console.ReadLine());
      rezultatas = suma;

      Array.Sort(intA);//Tam atvejui jai ivesti duomenys nera surusiuoti

      GaukSuma(intA, 0, suma, "{");//Rekursinis metodas sumai gauti

      Console.WriteLine(count);//Atsakymu skaicius

      //Atsakymu spauzdinimas
      foreach (string item in ats)
      {
        Console.WriteLine(item);
      }
    }

    static void GaukSuma(int[] arr, int index, int suma, string print)
    {
      for (int i = index; i < arr.Length; i++)
      {
        var tmpSuma = suma - arr[i];
        string tmpPrint = print;
        if (tmpPrint == "{")
        {
          //tuo atveju jai tai pirmas rekursijos gylis
          tmpPrint += "" + arr[i];
          //issaugomas indeksas atsakymams iterpti
          //skaicu masyvas isrusiuotas nuo didziausio iki maziausio
          //del to ilgiausia eilute bus iterpta pirma, veliau trumpesnes ja nustums zemyn
          atsIndex = ats.Count;
        }
        else tmpPrint += "," + arr[i];
        if (tmpSuma > 0) GaukSuma(arr, i, tmpSuma, tmpPrint);
        if (tmpSuma == 0)
        {
          count++;
          tmpPrint += "} = " + rezultatas;
          ats.Insert(atsIndex, tmpPrint);
        }
      }
    }
  }
}
