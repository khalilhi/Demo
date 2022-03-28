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
        HttpClient client= new HttpClient(); 
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

            if (textBoxUser.Text == string.Empty)
            {
                ValidationLabel.Content = "Vous devez choisir un utilisateur *";
                textBoxUser.Focus();
            }
            else if (PasswordBox.Password == string.Empty)
            {
                ValidationLabel.Content = "Vous devez choisir un mot de passe *";
                PasswordBox.Focus();
            }

            else if (res)
            {
                var menu = new Menu();
                menu.Show();
                this.Close();
            }
            else
            {
                ValidationLabel.Content = "Utilisateur ou mot de passe incorrect ";
                textBoxUser.Text = "";
                PasswordBox.Password = "";
            }
        }

        //private  async void getUser()
        //{
        //    var responce = await  client.GetStringAsync("https://localhost:44348/Utilisateur?id="+textBoxUser.Text);
        //    var User = JsonConvert.DeserializeObject<List<Utilisateur>>(responce);
        //    //ValidationLabel.Content = User[0].FirstName;
        //    if (User.Count==0 || User[0].MotPasse != PasswordBox.Password)
        //    {
        //        ValidationLabel.Content= "Utilisateur ou mot de passe incorrect ";
        //    }
        //    else
        //    {
        //        var menu = new Menu();
        //        menu.Show();
        //        this.Close();
                
        //    }
        //}

    }
}
