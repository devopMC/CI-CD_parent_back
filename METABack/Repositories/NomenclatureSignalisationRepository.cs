using METABack.Entities;
using METABack.Interfaces;

namespace METABack.Repositories
{
    public class NomenclatureSignalisationRepository : INomenclatureSignalisation
    {
        private readonly DatabaseContext _dbContext;

        public NomenclatureSignalisationRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSignalisation(NomenclatureSignalisation Signalisation)
        {
            try
            {
                _dbContext.NomenclatureSignalisations.Add(Signalisation);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
           
        }

        public List<NomenclatureConcerne> GetConcerneList()
        {
            try
            {
                return _dbContext.NomenclatureConcernes.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureInformateur> GetInformateurList()
        {
            try
            {
                return _dbContext.NomenclatureInformateurs.ToList();
            }
            catch
            {
                throw;
            }
        }

        public List<NomenclatureSignalisation> GetSignalisationList()
        {
            try
            {
                return _dbContext.NomenclatureSignalisations.ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}
