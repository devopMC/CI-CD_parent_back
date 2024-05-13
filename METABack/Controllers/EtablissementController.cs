using METABack.Entities;
using METABack.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace METABack.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class EtablissementController : Controller
    {
        private readonly IEtablissements _IEtablissement;
        private readonly DatabaseContext _dbContext;
        public EtablissementController(IEtablissements IEtablissement, DatabaseContext dbContext)
        {
            _IEtablissement = IEtablissement;
            _dbContext = dbContext;
        }
        
        [HttpGet("etablissements")]
        public async Task<ActionResult<IEnumerable<ViewEtablissement>>> Get()
        {
            return await Task.FromResult(_IEtablissement.GetEtablissementList());
        }
            
        //[EnableCors("MyPolicy")]
        //[HttpGet("etablissements")]
        //public async Task<ActionResult<IEnumerable<NomenclatureEtablissement>>> GetEtablissements()
        //{
        //    List<NomenclatureEtablissement> etablissements =  _dbContext.NomenclatureEtablissements.ToList();

        //    return etablissements;
        //}

        
        [HttpGet("Libe/{Libe}")]
        public async Task<ActionResult<IEnumerable<ViewEtablissement>>> GetByLibe(string Libe)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeAsync(Libe));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
            //return await Task.FromResult(_IEtablissement.());
        }

        
        [HttpGet("typesEtablissements")]
        public async Task<ActionResult<IEnumerable<NomenclatureTypeEtablissement>>> GetTypeEtablissement()
        {
            return await Task.FromResult(_IEtablissement.GetTypeEtabtList());
        }
        
        [HttpGet("EtatsEtablissements")]
        public async Task<ActionResult<IEnumerable<NomenclatureEtatEtablissement>>> GetEtatEtablissement()
        {
            return await Task.FromResult(_IEtablissement.GetEtatEtabtList());
        }

        
        [HttpGet("gouvernorat")]
        public async Task<ActionResult<IEnumerable<NomenclatureGouvernorat>>> GetGouvernorat()
        {
            return await Task.FromResult(_IEtablissement.GetGouvList());
        }

        
        [HttpGet("delegation")]
        public async Task<ActionResult<IEnumerable<NomenclatureDelegation>>> GetDelegation()
        {
            return await Task.FromResult(_IEtablissement.GetDeleList());
        }
       
        [HttpGet("delegation/{CodeGouv}")]
        public async Task<ActionResult<IEnumerable<NomenclatureDelegation>>> GetDeleByCodeGouv(string CodeGouv)
        {
            return await Task.FromResult(_IEtablissement.GetDeleByCodeGouv(CodeGouv));
        }

        
        [HttpGet("Gouv/{LibeGouv}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouv(string LibeGouv)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvAsync(LibeGouv));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }
        
        [HttpGet("{LibeGouv}/{LibeDele}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouvDele(string LibeGouv, string LibeDele)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvDele(LibeGouv, LibeDele));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }
        [EnableCors("MyPolicy")]
        [HttpGet("{LibeGouv}/{LibeDele}/{LibeComm}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetByLibeGouvDeleComm(string LibeGouv, string LibeDele, string LibeComm)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementByLibeGouvDeleComm(LibeGouv, LibeDele, LibeComm));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }
        [EnableCors("MyPolicy")]
        [HttpGet("Eat/{LibeEtatEtab}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetEtablissementsByLibeEtatEtab(string LibeEtatEtab)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementsByLibeEtatEtab(LibeEtatEtab));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }
        [EnableCors("MyPolicy")]
        [HttpGet("type/{LibeTypeEtab}")]
        public async Task<ActionResult<List<ViewEtablissement>>> GetEtablissementsByLibeTypeEtab(string LibeTypeEtatEtab)
        {
            var etablissements = await Task.FromResult(_IEtablissement.GetEtablissementsByLibeTypeEtab(LibeTypeEtatEtab));
            if (etablissements.Count == 0)
            {
                return NotFound();
            }
            return etablissements;
        }

        
        
        
        [HttpGet("/search")]
        public async Task<ActionResult<IEnumerable<ViewEtablissement>>> GetEtablissements([FromQuery] SearchCriteria criteria)
        {
            var etablissements = await _IEtablissement.GetEtablissementsByCriteriaAsync(criteria);
            return Ok(etablissements);
        }

        
        [HttpGet("{code}")]
        public ActionResult<ViewEtablissement> GetEtablissementByCodeEtab(string code)
        {
            try
            {
                var etablissement = _IEtablissement.GetEtablissementByCodeEtab(code);

                if (etablissement != null)
                {
                    return Ok(etablissement);
                }
                else
                {
                    return NotFound(); // Renvoie un code 404 si l'établissement n'est pas trouvé.
                }
            }
            catch (Exception ex)
            {
                // Gérez les exceptions ici, par exemple, en renvoyant une réponse d'erreur.
                return StatusCode(500, "Une erreur interne est survenue : " + ex.Message);
            }
        }
    }
}
