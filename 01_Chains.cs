using System.Linq;
using System;

public class Program
{
  public static void Main()
  {
    var a = new string[] { "1", "2", "3", "4" };

    var b = a.Where(n => { Console.WriteLine(n); return true; }).Select(n => { Console.WriteLine(n); return n + "E"; }).ToList();

    Console.WriteLine("Finished");
  }
}