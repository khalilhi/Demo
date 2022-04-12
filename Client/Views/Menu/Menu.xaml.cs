using Client.ViewModels;
using Client.Views.Agenda;
using Client.Views.Assistance;
using Client.Views.Commandes;
using Client.Views.Editeur;
using Client.Views.Livres;
using Client.Views.Parametrage;
using Client.Views.Profil;
using Client.Views.Utilisateurs;
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
using System.Windows.Shapes;

namespace Client
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
            main.Content = new Profil();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Menu = new MenuViewModel();
            Menu.Logout();
            this.Close();

        }

        private void RadButton_Click(object sender, RoutedEventArgs e)
        {
            main.Content = new Profil();
        }

        private void RadButton_Click_1(object sender, RoutedEventArgs e)
        {
            main.Content = new Editeur();
        }

        private void RadButton_Click_2(object sender, RoutedEventArgs e)
        {
            main.Content = new Utilisateur();
        }

        private void RadButton_Click_3(object sender, RoutedEventArgs e)
        {
            main.Content = new Livres();
        }

        private void RadButton_Click_4(object sender, RoutedEventArgs e)
        {
            main.Content = new Commande();
        }

        private void RadButton_Click_5(object sender, RoutedEventArgs e)
        {
            main.Content = new Agenda();
        }

        private void RadButton_Click_6(object sender, RoutedEventArgs e)
        {
            main.Content = new Parametrages();
        }

        private void RadButton_Click_7(object sender, RoutedEventArgs e)
        {
            main.Content = new Assistance();
        }
    }
}
