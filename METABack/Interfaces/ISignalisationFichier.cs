using METABack.Entities;

namespace METABack.Interfaces
{
    public interface ISignalisationFichier
    {
        void AddSignalisationFichierAsync(SignalisationFichier signalisationFichier,NomenclatureSignalisation siganlisation);
    }
}
