using System.Net.Mime;
using bontravailapi.Models;
using bontravailapi.Service.Role;
using Microsoft.AspNetCore.Mvc;

namespace bontravailapi.Controllers {
    
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    [Route("/api/role")]
    public class RolesController : ControllerBase {
        private readonly IRolesService rolesService ;
        private readonly ILogger<RolesController> logger;

        public RolesController(IRolesService rolesService,  ILogger<RolesController> logger){
            this.rolesService = rolesService;
            this.logger = logger;
        }

        [Route("liste")]
        [HttpGet]
        public async Task<List<Roles>>  Liste(){
            List<Roles> Liste = await this.rolesService.GetAll();
            logger.LogInformation("Liste role called ;");
            return Liste;
        }
    }
}