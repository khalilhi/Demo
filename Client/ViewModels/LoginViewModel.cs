using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private HttpClient client = new();
        public static Utilisateur? session = new ();
        public async Task<bool> GetUser(string id, string password)
        {
            session = null;
            var responce = await client.GetStringAsync("https://localhost:44367/Utilisateur?id=" + id);
            var User = JsonConvert.DeserializeObject<List<Utilisateur>>(responce);
            session = User[0];
            try
            {
                if (session==null || session.MotPasse != password)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ShowMenu()
        {
            var menu = new Menu();
            menu.Show();
        }

    }
}
