using Client.ViewModels;
using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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

namespace Client
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
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginViewModel lg = new LoginViewModel();
            var id = textBoxUser.Text;
            var pass = PasswordBox.Password;
            var res = await lg.GetUser(id, pass); 

            if (id == string.Empty)
            {
                ValidationLabel.Content = "Vous devez choisir un utilisateur *";
                textBoxUser.Focus();
            }
            else if (pass == string.Empty)
            {
                ValidationLabel.Content = "Vous devez choisir un mot de passe *";
                PasswordBox.Focus();
            }

            else if (res)
            {
                lg.ShowMenu();
                this.Close();
            }
            else
            {
                ValidationLabel.Content = "Utilisateur ou mot de passe incorrect ";
                textBoxUser.Text = String.Empty;
                PasswordBox.Password = String.Empty;
            }
        }
    }
}
