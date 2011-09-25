using System;



public class lendo {

	const byte tamanho = 10;
	
	public static void Main(){
		
		
		byte[] numeros = new byte[tamanho];
		float media = 0f;
		
		string leitura;
		
		for (int i = 0; i < tamanho; i++) {
			
			Console.Write("Insira um numero: ");
			leitura = Console.ReadLine();
			
			numeros[i] = byte.Parse(leitura);
			
			
			media += numeros[i] / (float) tamanho;
			
		}
		
		Console.WriteLine("Sua media: " + media);
		
		
	}
}
