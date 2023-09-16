using System;
using System.Windows.Forms;
using CustomLibrary;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Calc calc = new Calc();

            int a = 4;
            int b = 2;

            MessageBox.Show($"Sum{calc.Sum(a, b)}{Environment.NewLine}" +
                            $"Sub{calc.Sub(a, b)}{Environment.NewLine}" +
                            $"Mul{calc.Mul(a, b)}{Environment.NewLine}" +
                            $"Div{calc.Div(a, b)}{Environment.NewLine}");
        }
    }
}
