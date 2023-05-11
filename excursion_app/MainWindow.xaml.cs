using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace excursion_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<Reservation> reservations = new ObservableCollection<Reservation>();

        public MainWindow()
        {
            InitializeComponent();
            mainList.ItemsSource = reservations;
        }

        private void addItem_Click(object sender, RoutedEventArgs e)
        {
            AddItemWindow aiw = new AddItemWindow();
            aiw.Show();
            aiw.AddReservationAction += (reservation) =>
            {
                reservations.Add(reservation);
            };

        }

        private void remItem_Click(object sender, RoutedEventArgs e)
        {
        }

        private void mainList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                reservations.RemoveAt(mainList.SelectedIndex);
            }
        }

        private void mainList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
