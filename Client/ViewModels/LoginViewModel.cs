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
    public class LoginViewModel
    {
        HttpClient client = new HttpClient();
        public async Task<bool> GetUser(string id, string password)
        {
            var responce = await client.GetStringAsync("https://localhost:44348/Utilisateur?id="+id);
            var User = JsonConvert.DeserializeObject<List<Utilisateur>>(responce);

            if (User.Count == 0 || User[0].MotPasse != password)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
