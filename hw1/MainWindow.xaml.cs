using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace hw1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private int DotCounter = 0;
        private int IntResult = 0;
        private double DoubleResult = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void AddNumber(string number)
        {
         

            if (textBox1.Text == "0")
            {
                textBox2.Clear();
                textBox1.Text = number;
                textBox2.Text += number + " ";
            }
            else
            {
                textBox1.Text += number;
                textBox2.Text += number + " ";
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNumber("1");
          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddNumber("2");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AddNumber("3");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AddNumber("4");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AddNumber("5");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            AddNumber("6");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            AddNumber("7");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            AddNumber("8");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            AddNumber("9");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
  
            if (DotCounter <= 0)
            {
                if (textBox1.Text != "0")
                {
                    textBox1.Text += ".";
                    DotCounter++;
                }
            }
         
            
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text != "0")
            {
                textBox1.Text += "0";
            }
        }

        private void Button_Click_Plus(object sender, RoutedEventArgs e)
        {
            //string op = textBox1.Text;

            //if(textBox2.Text == "0")
            //{
            //    textBox2.Clear();
            //}


            //if (textBox2.Text != "+")
            //{
            //    textBox2.Text += " + ";
            //}

            //if (op.Contains("."))
            //{
            //    double operand = Convert.ToDouble(op);
            //    DoubleResult += operand;
            //}
            //else
            //{
            //    int operand = int.Parse(op);
            //    IntResult += operand;
            //}
            //textBox1.Clear();



            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }

            if (!textBox2.Text.Contains("+"))
            {
                textBox2.Text += " + ";
            }

            // Получаем первое число из textBox1
            if (int.TryParse(textBox1.Text, out int res1))
            {
                IntResult += res1; // Добавляем первое число к результату
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число в поле TextBox1");
                return;
            }

            // Получаем второе число из textBox2 (если оно нужно)
            if (int.TryParse(textBox2.Text.Replace("+", "").Trim(), out int res2))
            {
                IntResult += res2; // Добавляем второе число к результату
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка: Введите корректное число в поле TextBox2");
            }

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            if (textBox2.Text.Contains("."))
            {
                textBox1.Clear();
                string doubleRes = DoubleResult.ToString();
                textBox1.Text = doubleRes;
            }
            else
            {
                textBox1.Clear();
                string intRes = IntResult.ToString();
                textBox1.Text = intRes;
                textBox2.Text += " = " + intRes;
            }
        }
    }
}
