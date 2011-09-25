// Este programa le o proprio codigo
using System;
using System.IO;
class Lendo {
    static void Main() {
	StreamReader arquivoASerLido = new StreamReader("lendo_um_arquivo.cs");
	string linha;
	while ( (linha = arquivoASerLido.ReadLine()) != null) {
	    Console.WriteLine(linha);
	}
	arquivoASerLido.Close();
    }
}
