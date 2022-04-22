using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using System.Collections.Generic;
using Models.LoginModel;
using Models;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilisateurController : ControllerBase
    {
        UtilisateurRepository rep = new UtilisateurRepository();
        /*
        [HttpGet]
        public IEnumerable<Utilisateur> Get(int id)
        {
            return rep.GetUtilisateurByID(id);
        }

        */
        [HttpPost]
        public void add(Utilisateur _book)
        {
            rep.AddUtilisateur(_book);
        }

        [HttpDelete]

        public void Remove(int id)
        {
            rep.RemoveUtilisateurk(id);
        }
        [HttpPut]
        public void Update(Utilisateur book)
        {
            rep.UpdateUtilisateur(book);
        }

        [HttpGet]
        public Task<UtilisateurDto> GetByname(string firstName)
        {
            return rep.GetUtilisateurByIname(firstName);
        }

        [HttpPost]
         [Route("authUser")]
        public Task<UtilisateurDto> GetByname(RequestUserAuth requestedItem)
        {
            return rep.GetUtilisateurByIname(requestedItem);
        }
    }
}
