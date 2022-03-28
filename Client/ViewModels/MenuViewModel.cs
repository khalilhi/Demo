using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModels
{
    internal class MenuViewModel : BaseViewModel
    {
        public void Logout()
        {
            var m = new MainWindow();
            m.Show();
        }
    }
}
