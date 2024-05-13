namespace METABack.Entities
{
    public class NomenclatureDelegation
    {
        public string CodeDele { get; set; } = null!;
        public string? LibeDele { get; set; }
        public string? CodeGouv { get; set; }
        public int? OrdrAffi { get; set; }
        public bool? Acti { get; set; }
        public virtual NomenclatureGouvernorat? CodeGouvNavigation { get; set; }

        public virtual ICollection<EnfantNecessite> EnfantNecessites { get; set; } = new List<EnfantNecessite>();

        public virtual ICollection<EtablissementFicheEtablissement> EtablissementFicheEtablissements { get; set; } = new List<EtablissementFicheEtablissement>();

        public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissementCodeDeleFondNavigations { get; set; } = new List<NomenclatureEtablissement>();

        public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissementCodeDeleNavigations { get; set; } = new List<NomenclatureEtablissement>();

        public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();

        public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
    }
}
