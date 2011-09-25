using System.Windows.Forms;

public class Box {

    static void Main(string[] args) {
	
	string mensagem;
	string titulo;
	DialogResult resultado;
	
	
	mensagem = "Sem Mensagem";
	
	titulo = "Sem Titulo";
	
	if (args.Length > 0) {
	    mensagem = args[0];
	    if (args.Length > 1) {
		titulo = args[1];
	    }
	}
	    
	resultado = MessageBox.Show(mensagem, titulo, MessageBoxButtons.YesNo,
    	    	    		    MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, 
            			    MessageBoxOptions.RightAlign);
	
	if (resultado == DialogResult.No) {
	    System.Console.Write("Clicado no nao");
	} else if (resultado == DialogResult.Yes) {
	    System.Console.Write("Clicado no sim");
	}
    }
}