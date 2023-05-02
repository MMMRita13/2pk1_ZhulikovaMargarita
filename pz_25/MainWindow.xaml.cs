using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace pz_25
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void press8Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "8";
        }

        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "7";
        }

        private void press9Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "9";
        }

        private void press6Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "6";
        }

        private void press5Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "5";
        }

        private void press4Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "4";
        }

        private void press3Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "3";
        }

        private void press2Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "2";
        }

        private void press1Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "1";
        }

        private void press0Button_Click(object sender, RoutedEventArgs e)
        {
            infoTextBlock.Text += "0";
        }

        private void pressplusButton_Click(object sender, RoutedEventArgs e)
        {
            
            infoTextBlock.Text += "+";
        }

        private void pressminusButton_Click(object sender, RoutedEventArgs e)
        {
            
            infoTextBlock.Text += "-";

        }

        private void pressdelButton_Click(object sender, RoutedEventArgs e)
        {
            
            infoTextBlock.Text += "/";
        }
        private void pressymnozhButton_Click_1(object sender, RoutedEventArgs e)
        {
            
            infoTextBlock.Text += "*";
        }

        private void pressravnoButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = infoTextBlock.Text;
            infoTextBlock.Text = Calculator(expression).ToString();
        }
        private double Calculator(string expression)
        {
            // Преобразуем выражение в массив символов
            char[] tokens = expression.ToCharArray();

            // Создаем массив для хранения чисел и операций
            double[] numbers = new double[expression.Length];
            char[] operations = new char[expression.Length];

            int numIndex = 0;
            int opIndex = 0;

            // Парсим выражение, записываем числа и операции в массивы
            for (int i = 0; i < tokens.Length; i++)
            {
                if (tokens[i] == ' ')
                    continue;
                if (Char.IsDigit(tokens[i]))
                {
                    string numStr = "";
                    while (i < tokens.Length && (Char.IsDigit(tokens[i]) || tokens[i] == '.'))
                    {
                        numStr += tokens[i].ToString();
                        i++;
                    }
                    i--;
                    numbers[numIndex] = double.Parse(numStr);
                    numIndex++;
                }
                else
                {
                    operations[opIndex] = tokens[i];
                    opIndex++;
                }
            }

            // Вычисляем выражение
            double result = numbers[0];
            for (int i = 0; i < opIndex; i++)
            {
                char op = operations[i];
                double num = numbers[i + 1];
                switch (op)
                {
                    case '+':
                        result += num;
                        break;
                    case '-':
                        result -= num;
                        break;
                    case '*':
                        result *= num;
                        break;
                    case '/':
                        result /= num;
                        break;
                }
            }
            return result;
        }
    }
}
