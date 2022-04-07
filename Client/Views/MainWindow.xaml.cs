using Client.ViewModels;
using System;
using System.Windows;
using System.Windows.Controls;

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
                ValidationLabel.Content = "Vous devez choisir un utilisateur* ";
                textBoxUser.Focus();
            }
            else if (pass == string.Empty)
            {
                ValidationLabel.Content = "Vous devez choisir un mot de passe * ";
                PasswordBox.Focus();
            }
            else if (res)
            {
                lg.ShowMenu();
                this.Close();
            }
            else
            {
                ValidationLabel.Content = "Utilisateur ou mot de passe incorrect* ";
                textBoxUser.Text = String.Empty;
                PasswordBox.Password = String.Empty;
            }
        }
    }
}
