using System;

public class Leitura {

    public static void Main(string[] args) {
    
	int caracter;
	Console.WriteLine("Lendo um caracter do seu teclado" +
			  "Insira o caracter");
	caracter = Console.Read();
	
	Console.WriteLine("O caracter digitado foi: {0}", 
			  caracter.ToString());

    }
}