// created on 17/7/2003 at 14:40


using System;
using System.Text.RegularExpressions;

public class ChecarNota
{
  public static void Main()
  {
  	
		Regex r = new Regex(@"^(10|\d(\.\d+)?)$");
		string line;
  		line = Console.ReadLine();
		
		if(r.IsMatch(line))
      	   	Console.WriteLine("Eh uma nota valida");
      	else
      		Console.WriteLine("Nao eh uma nota valida");
    

  }
}
