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
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;

namespace excursion_app
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string PathJson = File.ReadAllText("reservation.json");
        private ObservableCollection<Reservation>? reservations = JsonConvert.DeserializeObject<ObservableCollection<Reservation>>(PathJson);
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

        private void Save(object sender, RoutedEventArgs e)
        {
            string jsonString = System.Text.Json.JsonSerializer.Serialize(reservations, new JsonSerializerOptions { WriteIndented = true });
            string PathJson = "reservation.json";
            File.WriteAllText(PathJson, jsonString);           
        }

        private void remItem_Click(object sender, RoutedEventArgs e)
        {
            
            reservations.RemoveAt(1);    

        }

        private void mainList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete)
            {
                reservations.RemoveAt(mainList.SelectedIndex);
            }
        }
    }
}
