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

namespace pz_26
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
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Действие выполнено");
        }
        private void escButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // закрытие окна
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void acceptButton2_Click(object sender, RoutedEventArgs e)
        {

        }

        static void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            //FileStream file1 = new FileStream("C:\\Users\\Маргарита\\2pk1_ZhulikovaMargarita\\pz_26\\data\\", FileMode.Create); //создание файла
            //StreamWriter writer1 = new StreamWriter(file1);
            //writer1.Write("");
            //writer1.Close();
            //FileStream file2 = new FileStream("C:\\Users\\Маргарита\\2pk1_ZhulikovaMargarita\\pz_26\\data\\", FileMode.Open); //открытие файла
            //StreamWriter writer2 = new StreamWriter(file2);
            //writer2.Write("");
            //writer2.Close();

        }
        private int GetLineIndexFromCharacterIndex()
        {
            int CaretIndex = 0;
            return CaretIndex;
        }
        private void UpdateCursorPosition(object textField)
        {
            //int row = textField.GetLineIndexFromCharacterIndex(textField.CaretIndex);
            //int col = textField.CaretIndex - textField.GetLineIndexFromCharacterIndex(row);
            //cursorPosition.Text = $"строка: {row + 1} столбец: {col + 1}";
        }
        private void newFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            CreateFileWindow createFileWindow = new CreateFileWindow();
            if (createFileWindow.ShowDialog() == true)
                _ = createFileWindow.FileName;
        }

    }
}
