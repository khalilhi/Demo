using Client.ViewModels;
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

namespace Client.Views.Livres
{
    /// <summary>
    /// Logique d'interaction pour Livres.xaml
    /// </summary>
    public partial class Livres : Page
    {
        public Livres()
        {
            InitializeComponent();
            var DC = new BookViewModel();
            base.DataContext = DC;
        }
    }
}
