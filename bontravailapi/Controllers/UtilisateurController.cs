using System.Net.Mime;
using bontravailapi.Models;
using bontravailapi.Service.Role;
using bontravailapi.Service.Utilisateurs;
using Microsoft.AspNetCore.Mvc;

namespace bontravailapi.Controllers {
    
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("/api/utilisateur")]
    public class UtilisateurController : ControllerBase {
        private readonly ILogger<UtilisateurController> logger;
        private readonly IUtilisateurService utilisateurService;

        public UtilisateurController(IUtilisateurService utilisateurService, ILogger<UtilisateurController> logger){
            this.logger = logger;
            this.utilisateurService = utilisateurService;
        }

        [Route("liste")]
        [HttpGet]
        public async Task<List<Utilisateur>>  Liste(){
             List<Utilisateur> Liste = await this.utilisateurService.GetAll();
            logger.LogInformation("Liste role called ;");
            return Liste;
        }
    }
}