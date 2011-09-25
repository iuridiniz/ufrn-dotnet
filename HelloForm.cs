namespace Microsoft.Samples.WinForms.Cs.SimpleHelloWorld {

    using System;
    using System.Windows.Forms;

    public class SimpleHelloWorld : Form {

        [STAThread]
        public static int Main(string[] args) {
            Application.Run(new SimpleHelloWorld());
            return 0;
        }

        public SimpleHelloWorld() {
            this.Text = "Hello World";
        }
    }
}

