using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;

namespace Client.ViewModels
{
    public class LoginViewModel
    {
        private HttpClient client = new HttpClient();
        public async Task<bool> GetUser(string id, string password)
        {
            var responce = await client.GetStringAsync("https://localhost:44367/Utilisateur?id=" + id);
            var User = JsonConvert.DeserializeObject<List<Utilisateur>>(responce);
            try
            {
                if (User.Count == 0 || User[0].MotPasse != password)
                {
                    return false;
                }
                else
                {
                    CacheObject.Id = User[0].Id;
                    CacheObject.Name = User[0].FirstName;
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
