using System;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Начальное значение X
            textBox1.Text = "-15,246";
            // Начальное значение Y
            textBox2.Text = "0,04642";
            // Начальное значение Z
            textBox3.Text = "2000,1";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "Лаба 2 Кищук ";
            // Считывание значения X
            double x = double.Parse(textBox1.Text);
            // Вывод значения X в окно
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            // Считывание значения Y
            double y = double.Parse(textBox2.Text);
            // Вывод значения Y в окно
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            // Считывание значения Z
            double z = double.Parse(textBox3.Text);
            // Вывод значения Z в окно
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            // Вычисляем арифметическое выражение
            double a = Math.Log(Math.Pow(y,-Math.Sqrt(Math.Abs(x)))) ;
            double b = x-(y/2);
            double c = Math.Pow(Math.Sin(Math.Atan(z)),2);
            double α = a * b + c; // Выводим результат в окно
            textBox4.Text += Environment.NewLine + "Результат α = " + α.ToString();
        }
    }
}
