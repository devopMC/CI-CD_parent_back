using METABack.Entities;

namespace METABack.Interfaces
{
    public interface INomenclatureSignalisation
    {
        public List<NomenclatureSignalisation> GetSignalisationList();
        public void AddSignalisation(NomenclatureSignalisation Signalisation);

        //type Informateurs
        public List<NomenclatureInformateur> GetInformateurList();

        //type Concerne
        public List<NomenclatureConcerne> GetConcerneList();


    }
}
