using METABack.Entities;
using METABack.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace METABack.Repositories
{
    public class EtablissementRepository : IEtablissements
    {
        private readonly DatabaseContext _dbContext ;

        public EtablissementRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }



        public async Task<IEnumerable<ViewEtablissement>> GetEtablissementsByCriteriaAsync(SearchCriteria criteria)
        {
            var query = _dbContext.ViewEtablissement.AsQueryable();
            // Appliquez les critères de recherche s'ils sont définis
            if (!string.IsNullOrEmpty(criteria.Gouvernorat))
            {
                query = query.Where(e => e.LibeGouv == criteria.Gouvernorat);
            }
            if (!string.IsNullOrEmpty(criteria.Delegation))
            {
                query = query.Where(e => e.LibeDele == criteria.Delegation);
            }
            if (!string.IsNullOrEmpty(criteria.Etat))
            {
                query = query.Where(e => e.LibeEtatEtab == criteria.Etat);
            }
            if (!string.IsNullOrEmpty(criteria.Type))
            {
                query = query.Where(e => e.LibeTypeEtab == criteria.Type);
            }

            var etablissements = await query.Where(e => e.AnneScol == 2022).ToListAsync();
            return etablissements;
        }




        public List<ViewEtablissement> GetEtablissementByLibeAsync(string Libe)
        {
            List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement
                .Where(e => e.LibeGouv == Libe || e.LibeDele == Libe || e.LibeTypeEtab == Libe || e.LibeEtatEtab == Libe)
                .ToList();
            return Etablissements;
        }


        public List<ViewEtablissement> GetEtablissementByLibeGouvAsync(string LibeGouv)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement.Where(e => e.LibeGouv == LibeGouv).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementByLibeGouvDele(string LibeGouv, string LibDele)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement.Where(e => e.LibeGouv == LibeGouv && e.LibeDele == LibDele).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementByLibeGouvDeleComm(string LibeGouv, string LibDele, string LibComm)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement.Where(e => e.LibeGouv == LibeGouv && e.LibeDele == LibDele && e.LibeComm == LibComm).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementsByLibeEtatEtab(string LibeEtatEtab)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement.Where(e => e.LibeEtatEtab == LibeEtatEtab).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementsByLibeTypeEtab(string LibeTypeEtab)
        {
            try
            {
                List<ViewEtablissement> Etablissements = _dbContext.ViewEtablissement.Where(e => e.LibeTypeEtab == LibeTypeEtab).ToList();
                return Etablissements;
            }
            catch
            {
                throw;
            }
        }

        public List<ViewEtablissement> GetEtablissementList()
        {
            try
            {
                return _dbContext.ViewEtablissement.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureTypeEtablissement> GetTypeEtabtList()
        {
            try
            {
                return _dbContext.NomenclatureTypeEtablissements.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureGouvernorat> GetGouvList()
        {
            try
            {
                return _dbContext.NomenclatureGouvernorats.ToList();
            }
            catch
            {
                throw;
            };
        }

        public List<NomenclatureDelegation> GetDeleList()
        {
            try
            {
                return _dbContext.NomenclatureDelegations.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureEtatEtablissement> GetEtatEtabtList()
        {
            try
            {
                return _dbContext.NomenclatureEtatEtablissements.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureDelegation> GetDeleByCodeGouv(string CodeGouv)
        {
            try {
                var delegations = _dbContext.NomenclatureDelegations
            .Where(dele => dele.CodeGouv == CodeGouv)
            .ToList();

                return delegations;
            }
            catch
            {
                throw;
            }
        }

        public ViewEtablissement GetEtablissementByCodeEtab(string code)
        {
            try
            {
                // Utilisez la méthode FirstOrDefault() pour obtenir le premier établissement correspondant au code.
                var etablissement = _dbContext.ViewEtablissement.FirstOrDefault(e => e.CodeEtab == code);

                // Vérifiez si l'établissement a été trouvé.
                if (etablissement != null)
                {
                    return etablissement;
                }
                else
                {
                    // Si l'établissement n'est pas trouvé, vous pouvez renvoyer null ou lancer une exception personnalisée.
                    return null; // Ou lancez une exception appropriée.
                }
            }
            catch (Exception ex)
            {
                // Gérez les exceptions ici.
                throw ex;
            }
        }
    }
}
