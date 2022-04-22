using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Client.Models;
using Models.LoginModel;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;

namespace Client.ViewModels
{
    public class LoginViewModel
    {
        private HttpClient client = new HttpClient();
        public async Task<bool> GetUser(string firstName, string password)
        {
            try
            {
                //var responce = await client.GetStringAsync("https://localhost:44367/Utilisateur?firstName=" + firstName);
                //var User = JsonConvert.DeserializeObject<UtilisateurDto>(responce);

                var param = new RequestUserAuth
                {
                    FirstName = firstName,
                    Password = password
                };

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                
                HttpContent content = new ObjectContent<object>(param, new JsonMediaTypeFormatter());
                var response = await client.PostAsync("https://localhost:44367/Utilisateur/authUser", content);
                if (response == null)
                {
                    return false;
                }
                else
                {
                    var userResponse = await response.Content.ReadAsStringAsync();
                    UtilisateurDto userResult = JsonConvert.DeserializeObject<UtilisateurDto>(userResponse);
                    if (userResult != null)
                    {
                        CacheObject.Id = userResult.Id;
                        CacheObject.Name = userResult.FirstName;
                        //a completer si besoin ...
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    // var User = JsonConvert.DeserializeObject<UtilisateurDto>(response.res);
                }


                //var responce = await client.GetStringAsync("https://localhost:44367/Utilisateur?id=" + id);
                //var User = JsonConvert.DeserializeObject<UtilisateurDto>(responce);
                //try
                //{
                //    if (User.Count == 0 || User[0].MotPasse != password)
                //    {
                //        return false;
                //    }
                //    else
                //    {
                //        CacheObject.Id = User[0].Id;
                //        CacheObject.Name = User[0].FirstName;
                //        return true;
                //    }
                //}
                //catch (Exception e)
                //{
                //    throw e;
                //}
            }
            catch
            {
                return false;
            }
        }
        public void ShowMenu()
        {
            var menu = new Menu();
            menu.Show();
        }

    }
}
