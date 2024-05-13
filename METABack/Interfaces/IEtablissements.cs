using METABack.Entities;

namespace METABack.Interfaces
{
    public interface IEtablissements
    {
        //rechercher par criteria
        public Task<IEnumerable<ViewEtablissement>> GetEtablissementsByCriteriaAsync(SearchCriteria criteria);


        //type Etablissement
        public List<NomenclatureTypeEtablissement> GetTypeEtabtList();
        //etat Etablissement
        public List<NomenclatureEtatEtablissement> GetEtatEtabtList();

        //liste deligation 
        public List<NomenclatureGouvernorat> GetGouvList();
        public List<NomenclatureDelegation> GetDeleByCodeGouv(string CodeGouv);

        //liste governorat
        public List<NomenclatureDelegation> GetDeleList();




        public List<ViewEtablissement> GetEtablissementList();
        public List<ViewEtablissement> GetEtablissementByLibeAsync(string Libe);
        public List<ViewEtablissement> GetEtablissementByLibeGouvAsync(string LibeGouv);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDele(string LibeGouv, string LibDele);
        public List<ViewEtablissement> GetEtablissementByLibeGouvDeleComm(string LibeGouv, string LibDele, string LibComm);
        public List<ViewEtablissement> GetEtablissementsByLibeEtatEtab(string LibeEtatEtab);
        public List<ViewEtablissement> GetEtablissementsByLibeTypeEtab(string LibeTypeEtatEtab);


        public ViewEtablissement GetEtablissementByCodeEtab(string code);


    }
}
