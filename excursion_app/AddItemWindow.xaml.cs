using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace excursion_app
{
    /// <summary>
    /// Логика взаимодействия для AddItemWindow.xaml
    /// </summary>
    public partial class AddItemWindow : Window
    {
        public delegate void CarInterception(Reservation reservation);
        public event CarInterception AddReservationAction;
        public AddItemWindow()
        {
            InitializeComponent();
        }

        internal void addItemButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Reservation reservation = new Reservation(fioTB.Text, int.Parse(pasportTB.Text), otkydaTB.Text, kydaTB.Text, short.Parse(peopleTB.Text), int.Parse(moneyTB.Text));
                AddReservationAction.Invoke(reservation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}
