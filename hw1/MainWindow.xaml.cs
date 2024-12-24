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

            string input = textBox1.Text;
            if (double.TryParse(input, out double operand))
            {
                DoubleResult += operand;

                textBox1.Clear();

            
            }

           

            if (double.TryParse(input, out double operand1))
            {
                DoubleResult += operand1;

                textBox1.Clear();
            }



            if (textBox2.Text == "0")
            {
                textBox2.Clear();
            }

            if (!textBox2.Text.Contains("+"))
            {
                textBox2.Text += " + ";
            }

   
            


          

        }

        private void Button_Click_CE(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            DoubleResult = 0;
        }

        private void Button_Click_Equals(object sender, RoutedEventArgs e)
        {

           

            if (!string.IsNullOrWhiteSpace(textBox2.Text))
            {
                string doubleRes = DoubleResult.ToString();
                textBox1.Text = doubleRes;
                textBox2.Text += $" = {doubleRes}";
            }

            DoubleResult = 0;


        }

        private void Button_Click_Minus(object sender, RoutedEventArgs e)
        {

            DoubleResult = 0;

            if (!textBox2.Text.Contains("-"))
            {
                textBox2.Text += " - ";
            }

            string input = textBox1.Text;

            double operand = Convert.ToDouble(input);

            textBox1.Clear();

            

            double operand1 = Convert.ToDouble(input);
            DoubleResult = operand - operand1;

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            textBox2.Text += " * ";
            string op = textBox1.Text;
            textBox1.Clear();
         

            double operand = Convert.ToDouble(op);
            double operand1 = Convert.ToDouble(op);

            DoubleResult = operand * operand1;


        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            textBox2.Text += " / ";
            string op = textBox1.Text;
            textBox1.Clear();


            double operand = Convert.ToDouble(op);
            double operand1 = Convert.ToDouble(op);

            if(operand != 0 || operand1 != 0) {

                DoubleResult = operand / operand1;

            }
  
        }

        private void Button_Click_C(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            DoubleResult = 0;
        }

        private void Button_Click_Less(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();

        }
    }
}
