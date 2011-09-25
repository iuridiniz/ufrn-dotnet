namespace Function 
{
    using System;
     /// <summary>
     /// Testes com fun��es
     /// </summary>
    public class Class1 
    {
	 /// <summary> 
	 /// Soma dois n�meros
	 /// </summary>
	 /// <param name="A"> Um n�mero </param>
	 /// <param name="B"> Outro n�mero </param>
	static double soma(double A, double B)
	{
	    return (A+B);
	}
	 /// <summary> 
	 /// Soma dois n�meros
	 /// </summary>
	 /// <param name="A"> Um n�mero </param>
	 /// <param name="B"> Outro n�mero </param>
	 /// <param name="R"> Resultado </param>
	static void soma(double A, double B, double R)
	{
	    R = A+B;
	}
	static void soma(double A, double B, ref double R)
	{
	    R = A+B;
	}
	static void Soma(double A, double B, out double R)
	{
	    R = A+B;
	}
	static void Mensagem()
	{
	    Console.WriteLine("In�cio");
	}
	public static int Main(string[] args)
	{
	    Mensagem();
	    
	    double R = soma(3,6);
	    Console.WriteLine(R);
	    
	    soma(30,20, R);
	    Console.WriteLine(R);
	    
	    soma(30, 20, ref R);
	    Console.WriteLine(R);
	    
	    soma(30, 20, R);
	    Console.WriteLine(R);
	    
	    return 0;
	}
    }
}