using System;

class MainClass {
  public static void Main (string[] args) 
  {
    Console.WriteLine ("Waddle C# by Torbjørn Marø");
    while(true)
    {
      Print(Eval(Read()));
    }
  }

  private static object Read()
  {
    Console.Write("? ");
    return Console.ReadLine();
  }

  private static object Eval(object ast)
  {
    return ast;
  }

  private static void Print(object result)
  {
    Console.WriteLine(result);
  }
}