using bontravailapi.Models;
using bontravailapi.Service.BonTravails;
using Microsoft.AspNetCore.Mvc;

namespace bontravailapi.Controllers {

    [ApiController]
    [Route("/api/bontravail/")]
    public class BonTravailController : ControllerBase {

        private readonly IBonTravailService BonTravailService ;

        public BonTravailController(IBonTravailService BonTravailService){
            this.BonTravailService = BonTravailService;
        }

        [Route("/api/bontravail/liste")]
        [HttpGet]
        public async Task<ActionResult<IList<BonTravail>>>  Liste(){
            List<BonTravail> Liste = await this.BonTravailService.GetAll();
            return Liste;
        }
    }
}