using DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;

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
        public IEnumerable<Utilisateur> GetByname(string id)
        {
            return rep.GetUtilisateurByIname(id);
        }
    }
}
