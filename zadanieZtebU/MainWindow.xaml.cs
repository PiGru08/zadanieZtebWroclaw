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

namespace zadanieZtebU
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string PubHaslo = "";
        public MainWindow()
        {
            InitializeComponent();
        }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        string imie = PoleImie.Text;
        string nazwisko = PoleNazwisko.Text;
            string posada = posadaPracownika.Text;

            MessageBox.Show("Dane pracownika: " + imie + ", " + nazwisko +", "+ posada+  " Hasło: " + PubHaslo);
          

         

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PubHaslo = "";
            int dlugosc = 0;
            Random random = new Random();
            if(int.TryParse(liczbaZnakow.Text, out dlugosc))
            {
                if(maleIduzeLitery.IsChecked == true)
                {
                    string duze = "QWERTYUIOPASDFGHJKLZXCVBNM";
                    int indeks = random.Next(duze.Length);
                    PubHaslo = PubHaslo + duze[indeks];
                }
                if(cyfry.IsChecked == true)
                {
                    int cyfra = random.Next(10);
                    PubHaslo = PubHaslo + cyfra.ToString();
                }
                if(znakisp.IsChecked == true)
                {
                    string znaki = "!@#$%^&*()_-+~`{}[];:|/?|";
                    int indeks = random.Next(znaki.Length);
                    PubHaslo = PubHaslo + znaki[indeks];
                }
                while (PubHaslo.Length < dlugosc)
                {
                    string male = "qwertyuiopasdfghjklzxcvbnm";
                    int indeks = random.Next(male.Length);
                    PubHaslo += male[indeks];
                }
                MessageBox.Show("Hasło: " + PubHaslo);
            }
            else
            {
                MessageBox.Show("Długość musi być liczbą");
            }
        }
    }
}
