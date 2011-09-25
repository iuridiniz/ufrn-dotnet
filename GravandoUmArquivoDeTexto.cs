// Este programa le os dados da entrada e os grava em um arquivo
using System;
using System.IO;
class Gravando {
    public static void Main(string[] args) {
	
	StreamWriter arquivo;
	if (args.Length == 0) {
	    Console.WriteLine("passe o nome do arquivo a ser lido");
	    return;
	} else {
	    try {
		arquivo = new StreamWriter(args[0]);
	    } 
	    catch {
		Console.WriteLine("Nao posso criar o arquivo");
		return;
	    }
	}
	Console.WriteLine("Digite o conteudo do arquivo, " + 
			  "quando acabar digite um linha contendo: FIM");
	string linha = Console.ReadLine();
	while (linha != "FIM") {
	    arquivo.WriteLine(linha);
	    linha = Console.ReadLine();
	}
	arquivo.Close();
    }
}