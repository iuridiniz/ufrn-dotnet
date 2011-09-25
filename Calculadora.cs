// created on 18/7/2003 at 08:55
using System;
using System.Windows.Forms;

namespace Calculadora {
	public class Calculadora : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Button botaoLimpar;
		private System.Windows.Forms.Button operadorVezes;
		private System.Windows.Forms.Button numeroQuatro;
		private System.Windows.Forms.Button numeroDois;
		private System.Windows.Forms.Button operadorMais;
		private System.Windows.Forms.Button operadorIgual;
		private System.Windows.Forms.Button operadorDivide;
		private System.Windows.Forms.Button numeroUm;
		private System.Windows.Forms.Button numeroSete;
		private System.Windows.Forms.Button numeroSeis;
		private System.Windows.Forms.Button numeroCinco;
		private System.Windows.Forms.TextBox resultado;
		private System.Windows.Forms.Button botaoApagar;
		private System.Windows.Forms.Button operadorMenos;
		private System.Windows.Forms.Label Autor;
		private System.Windows.Forms.Panel controlesDaCalculadora;
		private System.Windows.Forms.Button separadorFracao;
		private System.Windows.Forms.Button numeroOito;
		private System.Windows.Forms.Button numeroZero;
		private System.Windows.Forms.Button numeroTres;
		private System.Windows.Forms.Button numeroNove;
		
		
		//meus dados
		
		private bool cliqueEmOperador; 
		private Operacoes tipoDeOperacao;
		
		private string resultadoAntigo;
		private string resultadoNovo;
		
		private float parametro1;
		private float parametro2;
		
		
		//meus métodos
		
		private void EscrevendoNumeros(){
			this.operadorIgual.Focus();
			
			//previne zeros a esquerda
			if (this.resultado.Text == "0"){
				this.resultado.Text = "";
			}
			
			//apaga o conteudo de resuldado caso 
			//tenha sido a ultima acao tenha sido um
			//clique em um operador
			if (this.cliqueEmOperador) {
				this.resultado.Text="";
				this.cliqueEmOperador = false;
			}
			
		
			
		}
		
		private bool RealizandoOperacoes() {
			
			this.cliqueEmOperador = true;
			this.operadorIgual.Focus();
						
			if (this.resultadoNovo != "") {
				this.resultadoAntigo = this.resultadoNovo;
			}
			
			if (this.resultado.Text == "") {
				this.resultado.Text = "0";
			}
			
			this.resultadoNovo = this.resultado.Text;
			
			
		//	if ( this.tipoDeOperacao == Operacoes.nenhuma ) {
		//		return (false);
		//	}
			
			if ( this.resultadoAntigo != "" ) {
				
				this.parametro1 = float.Parse(this.resultadoAntigo);
				this.parametro2 = float.Parse(this.resultadoNovo);
			
				
			
				Console.WriteLine("numero antigo: " + this.resultadoAntigo);
				Console.WriteLine("numero novo: " + this.resultadoNovo);
				Console.WriteLine("Tipo de operacao: " + this.tipoDeOperacao);
			
				switch(this.tipoDeOperacao) {
					case (Operacoes.soma):
						Console.WriteLine("resultado: " + this.parametro1.ToString() + " + " + this.parametro2.ToString());
						this.resultadoNovo = this.resultado.Text = (this.parametro1 + this.parametro2).ToString();
						break;
					case (Operacoes.subtracao):
						Console.WriteLine("resultado: " + this.parametro1.ToString() + " - " + this.parametro2.ToString());
						this.resultadoNovo = this.resultado.Text = (this.parametro1 - this.parametro2).ToString();
						break;
					case (Operacoes.multiplicacao):
						Console.WriteLine("resultado: " + this.parametro1.ToString() + " * " + this.parametro2.ToString());
						this.resultadoNovo = this.resultado.Text = (this.parametro1 * this.parametro2).ToString();
						break;
					case (Operacoes.divisao):
						Console.WriteLine("resultado: " + this.parametro1.ToString() + " / " + this.parametro2.ToString());
						this.resultadoNovo = this.resultado.Text = (this.parametro1 / this.parametro2).ToString();
						break;

				
				}
				return (true);
			}
			return (false);
		}
		
		private void MudandoDados(){
			if (this.cliqueEmOperador) {
				this.resultado.Text="";
				this.cliqueEmOperador = false;
			}
			this.operadorIgual.Focus();
		}
		
		
		//método Main
		public static void Main() {
			Application.Run(new Calculadora());
		}
		
		//Construtor
		public Calculadora()
		{
			this.resultadoAntigo = "";
			this.resultadoNovo = "";
			this.parametro1 = 0f;
			this.parametro2 = 0f;
			this.cliqueEmOperador = false;
			this.tipoDeOperacao = Operacoes.nenhuma;
			
			InitializeComponent();
		}
		
		// THIS METHOD IS MAINTAINED BY THE FORM DESIGNER
		// DO NOT EDIT IT MANUALLY! YOUR CHANGES ARE LIKELY TO BE LOST
		void numeroSeteClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "7";
		}
		
		void numeroOitoClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "8";
		}
		
		void numeroNoveClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "9";
		}
		
		void numeroQuatroClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "4";
		}
		
		void numeroCincoClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "5";
		}
		
		void numeroSeisClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "6";
		}
		
		void numeroUmClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "1";
		}
		
		void numeroDoisClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "2";
		}
		
		void numeroTresClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			this.resultado.Text += "3";
		}
		
		void separadorFracaoClick(object sender, System.EventArgs e)
		{
			this.MudandoDados();
			
			//verifica se já não existe vírgula
			if ( resultado.Text.IndexOf(',') == -1 ) {
				
				if ( this.resultado.Text == "" ) {
					this.resultado.Text = "0,";
				} else {
					this.resultado.Text += ",";
				}
				
			}
		}
		
		void numeroZeroClick(object sender, System.EventArgs e)
		{
			this.EscrevendoNumeros();
			
			this.resultado.Text += "0";
		}
		
		void botaoApagarClick(object sender, System.EventArgs e)
		{
			
			this.MudandoDados();
			
			byte tamanho = (byte)this.resultado.Text.Length;
			
			if ( tamanho > 0 ) {

				string resultadoDepoisDaRemocao = this.resultado.Text.Remove(tamanho - 1, 1);
				this.resultado.Text = resultadoDepoisDaRemocao;
				
				
			}
			
		}
		
		void botaoLimparClick(object sender, System.EventArgs e)
		{
			this.resultadoAntigo = "";
			this.resultadoNovo = "";
			this.resultado.Text = "";
			this.tipoDeOperacao = Operacoes.nenhuma;
			this.operadorIgual.Focus();
		}
		
		void operadorMaisClick(object sender, System.EventArgs e)
		{
			
			this.RealizandoOperacoes();
			this.tipoDeOperacao = Operacoes.soma;
			
		}
		
		void operadorMenosClick(object sender, System.EventArgs e)
		{
			
			this.RealizandoOperacoes();
			this.tipoDeOperacao = Operacoes.subtracao;
			
		}
		
		void operadorVezesClick(object sender, System.EventArgs e)
		{
			
			this.RealizandoOperacoes();
			this.tipoDeOperacao = Operacoes.multiplicacao;
			
		}
		
		void operadorDivideClick(object sender, System.EventArgs e)
		{
			
			this.RealizandoOperacoes();
			this.tipoDeOperacao = Operacoes.divisao;
			
		}
		
		void operadorIgualClick(object sender, System.EventArgs e)
		{
			
			this.RealizandoOperacoes();
			this.tipoDeOperacao = Operacoes.nenhuma;
			
		}
		

		void operadorIgualKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyValue){
                case 96:
                        this.numeroZeroClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 97:
                        this.numeroUmClick(new object(), 
                                           new System.EventArgs());
                        break;
                case 98:
                        // " 2 "
                        this.numeroDoisClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 99:
                        // " 3 "
                        this.numeroTresClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 100:
                        // " 4 "
                        this.numeroQuatroClick(new object(), 
                                              new System.EventArgs());
                        break;
                case 101:
                        // " 5 "
                        this.numeroCincoClick(new object(), 
                                              new System.EventArgs());
                        break;
                case 102:
                        // " 6 "
                        this.numeroSeisClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 103:
                        // " 7 " 
                        this.numeroSeteClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 104:
                        // " 8 "
                        this.numeroOitoClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 105:
                        // " 9 "
                        this.numeroNoveClick(new object(), 
                                             new System.EventArgs());
                        break;
                case 27:
                        // ESC
                        this.botaoLimparClick(new object(), 
                                              new System.EventArgs());
                        break;
				case 8:
						// backspace
						this.botaoApagarClick(new object(),
						                      new System.EventArgs());
						break;
                case 107:
                        // " + "
                        this.operadorMaisClick(new object(), 
                                               new System.EventArgs());
                        break;
                case 109:
                        // " - "
                        this.operadorMenosClick(new object(), 
                                                new System.EventArgs());
                        break;
                case 106: 
                        // " * "
                        this.operadorVezesClick(new object(), 
                                                new System.EventArgs());
                        break;
                case 111:
                        // " / "
                        this.operadorDivideClick(new object(), 
                                                 new System.EventArgs());
                        break;
                case 110:
                        // decimal " , " ou " . "
                        this.separadorFracaoClick(new object(), 
                                                  new System.EventArgs());
                        break;

        	}
	
		}

		void InitializeComponent() {
			this.numeroNove = new System.Windows.Forms.Button();
			this.numeroTres = new System.Windows.Forms.Button();
			this.numeroZero = new System.Windows.Forms.Button();
			this.numeroOito = new System.Windows.Forms.Button();
			this.separadorFracao = new System.Windows.Forms.Button();
			this.controlesDaCalculadora = new System.Windows.Forms.Panel();
			this.Autor = new System.Windows.Forms.Label();
			this.operadorMenos = new System.Windows.Forms.Button();
			this.botaoApagar = new System.Windows.Forms.Button();
			this.resultado = new System.Windows.Forms.TextBox();
			this.numeroCinco = new System.Windows.Forms.Button();
			this.numeroSeis = new System.Windows.Forms.Button();
			this.numeroSete = new System.Windows.Forms.Button();
			this.numeroUm = new System.Windows.Forms.Button();
			this.operadorDivide = new System.Windows.Forms.Button();
			this.operadorIgual = new System.Windows.Forms.Button();
			this.operadorMais = new System.Windows.Forms.Button();
			this.numeroDois = new System.Windows.Forms.Button();
			this.numeroQuatro = new System.Windows.Forms.Button();
			this.operadorVezes = new System.Windows.Forms.Button();
			this.botaoLimpar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			this.controlesDaCalculadora.SuspendLayout();
			// 
			// numeroNove
			// 
			this.numeroNove.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroNove.ForeColor = System.Drawing.Color.Blue;
			this.numeroNove.Location = new System.Drawing.Point(72, 16);
			this.numeroNove.Name = "numeroNove";
			this.numeroNove.Size = new System.Drawing.Size(24, 23);
			this.numeroNove.TabIndex = 2;
			this.numeroNove.TabStop = false;
			this.numeroNove.Text = "9";
			this.numeroNove.Click += new System.EventHandler(this.numeroNoveClick);
			// 
			// numeroTres
			// 
			this.numeroTres.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroTres.ForeColor = System.Drawing.Color.Blue;
			this.numeroTres.Location = new System.Drawing.Point(72, 80);
			this.numeroTres.Name = "numeroTres";
			this.numeroTres.Size = new System.Drawing.Size(24, 23);
			this.numeroTres.TabIndex = 8;
			this.numeroTres.TabStop = false;
			this.numeroTres.Text = "3";
			this.numeroTres.Click += new System.EventHandler(this.numeroTresClick);
			// 
			// numeroZero
			// 
			this.numeroZero.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroZero.ForeColor = System.Drawing.Color.Blue;
			this.numeroZero.Location = new System.Drawing.Point(40, 112);
			this.numeroZero.Name = "numeroZero";
			this.numeroZero.Size = new System.Drawing.Size(24, 23);
			this.numeroZero.TabIndex = 9;
			this.numeroZero.TabStop = false;
			this.numeroZero.Text = "0";
			this.numeroZero.Click += new System.EventHandler(this.numeroZeroClick);
			// 
			// numeroOito
			// 
			this.numeroOito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroOito.ForeColor = System.Drawing.Color.Blue;
			this.numeroOito.Location = new System.Drawing.Point(40, 16);
			this.numeroOito.Name = "numeroOito";
			this.numeroOito.Size = new System.Drawing.Size(24, 23);
			this.numeroOito.TabIndex = 1;
			this.numeroOito.TabStop = false;
			this.numeroOito.Text = "8";
			this.numeroOito.Click += new System.EventHandler(this.numeroOitoClick);
			// 
			// separadorFracao
			// 
			this.separadorFracao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.separadorFracao.Font = new System.Drawing.Font("Tahoma", 8F);
			this.separadorFracao.ForeColor = System.Drawing.Color.Blue;
			this.separadorFracao.Location = new System.Drawing.Point(8, 112);
			this.separadorFracao.Name = "separadorFracao";
			this.separadorFracao.Size = new System.Drawing.Size(24, 23);
			this.separadorFracao.TabIndex = 15;
			this.separadorFracao.TabStop = false;
			this.separadorFracao.Text = ",";
			this.separadorFracao.Click += new System.EventHandler(this.separadorFracaoClick);
			// 
			// controlesDaCalculadora
			// 
			this.controlesDaCalculadora.Controls.AddRange(new System.Windows.Forms.Control[] {
						this.Autor,
						this.botaoLimpar,
						this.botaoApagar,
						this.separadorFracao,
						this.operadorIgual,
						this.operadorDivide,
						this.operadorVezes,
						this.operadorMenos,
						this.operadorMais,
						this.numeroZero,
						this.numeroTres,
						this.numeroDois,
						this.numeroUm,
						this.numeroSeis,
						this.numeroCinco,
						this.numeroQuatro,
						this.numeroNove,
						this.numeroOito,
						this.numeroSete});
			this.controlesDaCalculadora.Location = new System.Drawing.Point(0, 32);
			this.controlesDaCalculadora.Name = "controlesDaCalculadora";
			this.controlesDaCalculadora.Size = new System.Drawing.Size(136, 176);
			this.controlesDaCalculadora.TabIndex = 0;
			// 
			// Autor
			// 
			this.Autor.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.Autor.Location = new System.Drawing.Point(64, 0);
			this.Autor.Name = "Autor";
			this.Autor.Size = new System.Drawing.Size(72, 16);
			this.Autor.TabIndex = 18;
			this.Autor.Text = "Autor: CLX";
			// 
			// operadorMenos
			// 
			this.operadorMenos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.operadorMenos.ForeColor = System.Drawing.Color.Red;
			this.operadorMenos.Location = new System.Drawing.Point(104, 48);
			this.operadorMenos.Name = "operadorMenos";
			this.operadorMenos.Size = new System.Drawing.Size(24, 23);
			this.operadorMenos.TabIndex = 11;
			this.operadorMenos.TabStop = false;
			this.operadorMenos.Text = "-";
			this.operadorMenos.Click += new System.EventHandler(this.operadorMenosClick);
			// 
			// botaoApagar
			// 
			this.botaoApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botaoApagar.Location = new System.Drawing.Point(8, 144);
			this.botaoApagar.Name = "botaoApagar";
			this.botaoApagar.Size = new System.Drawing.Size(56, 23);
			this.botaoApagar.TabIndex = 16;
			this.botaoApagar.TabStop = false;
			this.botaoApagar.Text = "Apagar";
			this.botaoApagar.Click += new System.EventHandler(this.botaoApagarClick);
			// 
			// resultado
			// 
			this.resultado.BackColor = System.Drawing.Color.White;
			this.resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.resultado.ForeColor = System.Drawing.Color.Blue;
			this.resultado.Location = new System.Drawing.Point(0, 8);
			this.resultado.Name = "resultado";
			this.resultado.ReadOnly = true;
			this.resultado.Size = new System.Drawing.Size(136, 20);
			this.resultado.TabIndex = 1;
			this.resultado.Text = "";
			this.resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.resultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.operadorIgualKeyDown);
			// 
			// numeroCinco
			// 
			this.numeroCinco.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroCinco.ForeColor = System.Drawing.Color.Blue;
			this.numeroCinco.Location = new System.Drawing.Point(40, 48);
			this.numeroCinco.Name = "numeroCinco";
			this.numeroCinco.Size = new System.Drawing.Size(24, 23);
			this.numeroCinco.TabIndex = 4;
			this.numeroCinco.TabStop = false;
			this.numeroCinco.Text = "5";
			this.numeroCinco.Click += new System.EventHandler(this.numeroCincoClick);
			// 
			// numeroSeis
			// 
			this.numeroSeis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroSeis.ForeColor = System.Drawing.Color.Blue;
			this.numeroSeis.Location = new System.Drawing.Point(72, 48);
			this.numeroSeis.Name = "numeroSeis";
			this.numeroSeis.Size = new System.Drawing.Size(24, 23);
			this.numeroSeis.TabIndex = 5;
			this.numeroSeis.TabStop = false;
			this.numeroSeis.Text = "6";
			this.numeroSeis.Click += new System.EventHandler(this.numeroSeisClick);
			// 
			// numeroSete
			// 
			this.numeroSete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroSete.ForeColor = System.Drawing.Color.Blue;
			this.numeroSete.Location = new System.Drawing.Point(8, 16);
			this.numeroSete.Name = "numeroSete";
			this.numeroSete.Size = new System.Drawing.Size(24, 23);
			this.numeroSete.TabIndex = 14;
			this.numeroSete.TabStop = false;
			this.numeroSete.Text = "7";
			this.numeroSete.Click += new System.EventHandler(this.numeroSeteClick);
			// 
			// numeroUm
			// 
			this.numeroUm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroUm.ForeColor = System.Drawing.Color.Blue;
			this.numeroUm.Location = new System.Drawing.Point(8, 80);
			this.numeroUm.Name = "numeroUm";
			this.numeroUm.Size = new System.Drawing.Size(24, 23);
			this.numeroUm.TabIndex = 6;
			this.numeroUm.TabStop = false;
			this.numeroUm.Text = "1";
			this.numeroUm.Click += new System.EventHandler(this.numeroUmClick);
			// 
			// operadorDivide
			// 
			this.operadorDivide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.operadorDivide.ForeColor = System.Drawing.Color.Red;
			this.operadorDivide.Location = new System.Drawing.Point(104, 112);
			this.operadorDivide.Name = "operadorDivide";
			this.operadorDivide.Size = new System.Drawing.Size(24, 23);
			this.operadorDivide.TabIndex = 13;
			this.operadorDivide.TabStop = false;
			this.operadorDivide.Text = "/";
			this.operadorDivide.Click += new System.EventHandler(this.operadorDivideClick);
			// 
			// operadorIgual
			// 
			this.operadorIgual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.operadorIgual.ForeColor = System.Drawing.Color.Red;
			this.operadorIgual.Location = new System.Drawing.Point(72, 112);
			this.operadorIgual.Name = "operadorIgual";
			this.operadorIgual.Size = new System.Drawing.Size(24, 23);
			this.operadorIgual.TabIndex = 0;
			this.operadorIgual.Text = "=";
			this.operadorIgual.Click += new System.EventHandler(this.operadorIgualClick);
			this.operadorIgual.KeyDown += new System.Windows.Forms.KeyEventHandler(this.operadorIgualKeyDown);
			// 
			// operadorMais
			// 
			this.operadorMais.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.operadorMais.ForeColor = System.Drawing.Color.Red;
			this.operadorMais.Location = new System.Drawing.Point(104, 16);
			this.operadorMais.Name = "operadorMais";
			this.operadorMais.Size = new System.Drawing.Size(24, 23);
			this.operadorMais.TabIndex = 10;
			this.operadorMais.TabStop = false;
			this.operadorMais.Text = "+";
			this.operadorMais.Click += new System.EventHandler(this.operadorMaisClick);
			// 
			// numeroDois
			// 
			this.numeroDois.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroDois.ForeColor = System.Drawing.Color.Blue;
			this.numeroDois.Location = new System.Drawing.Point(40, 80);
			this.numeroDois.Name = "numeroDois";
			this.numeroDois.Size = new System.Drawing.Size(24, 23);
			this.numeroDois.TabIndex = 7;
			this.numeroDois.TabStop = false;
			this.numeroDois.Text = "2";
			this.numeroDois.Click += new System.EventHandler(this.numeroDoisClick);
			// 
			// numeroQuatro
			// 
			this.numeroQuatro.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.numeroQuatro.ForeColor = System.Drawing.Color.Blue;
			this.numeroQuatro.Location = new System.Drawing.Point(8, 48);
			this.numeroQuatro.Name = "numeroQuatro";
			this.numeroQuatro.Size = new System.Drawing.Size(24, 23);
			this.numeroQuatro.TabIndex = 3;
			this.numeroQuatro.TabStop = false;
			this.numeroQuatro.Text = "4";
			this.numeroQuatro.Click += new System.EventHandler(this.numeroQuatroClick);
			// 
			// operadorVezes
			// 
			this.operadorVezes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.operadorVezes.ForeColor = System.Drawing.Color.Red;
			this.operadorVezes.Location = new System.Drawing.Point(104, 80);
			this.operadorVezes.Name = "operadorVezes";
			this.operadorVezes.Size = new System.Drawing.Size(24, 23);
			this.operadorVezes.TabIndex = 12;
			this.operadorVezes.TabStop = false;
			this.operadorVezes.Text = "*";
			this.operadorVezes.Click += new System.EventHandler(this.operadorVezesClick);
			// 
			// botaoLimpar
			// 
			this.botaoLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.botaoLimpar.Location = new System.Drawing.Point(72, 144);
			this.botaoLimpar.Name = "botaoLimpar";
			this.botaoLimpar.Size = new System.Drawing.Size(56, 23);
			this.botaoLimpar.TabIndex = 17;
			this.botaoLimpar.TabStop = false;
			this.botaoLimpar.Text = "Limpar";
			this.botaoLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.botaoLimpar.Click += new System.EventHandler(this.botaoLimparClick);
			// 
			// Calculadora
			// 
			this.ClientSize = new System.Drawing.Size(136, 207);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
						this.resultado,
						this.controlesDaCalculadora});
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Opacity = 0.9;
			this.Text = "Calculadora";
			this.controlesDaCalculadora.ResumeLayout(false);
			this.ResumeLayout(false);
		}
	}
	enum Operacoes { nenhuma = 0, soma, subtracao, multiplicacao, divisao };
	

}
