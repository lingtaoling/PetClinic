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

namespace VetClinic
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

        private void BtnAppointments_Click(object sender, RoutedEventArgs e)
        {
           Home.Content = new Appointments();
        }
        private void BtnPetProfile_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new PetProfile();
        }

        private void BtnVets_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new Vets();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new Login();
        }

        private void BtnPrescriptions_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new Prescriptions();
        }

        private void BtnBookAppointment_Click(object sender, RoutedEventArgs e)
        {
            Home.Content = new BookAppointment();
        }
    }
}
