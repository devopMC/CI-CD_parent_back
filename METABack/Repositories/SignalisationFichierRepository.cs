using METABack.Entities;
using METABack.Interfaces;
using System.Net.Http.Headers;

namespace METABack.Repositories
{
    public class SignalisationFichierRepository : ISignalisationFichier
    {
        private readonly DatabaseContext _dbContext;
        public SignalisationFichierRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void AddSignalisationFichierAsync(SignalisationFichier signalisationFichier, NomenclatureSignalisation siganlisation)
        {
            SignalisationFichier Signafichier = new SignalisationFichier();
            Signafichier.CodeSignalisation = siganlisation.CodeSignalisation;
            _dbContext.SignalisationFichiers.Add(Signafichier);
            _dbContext.SaveChangesAsync();
        }
    }
}
