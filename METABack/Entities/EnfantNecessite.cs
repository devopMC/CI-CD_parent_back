namespace METABack.Entities
{
    public class EnfantNecessite
    {
        public int Idenfant { get; set; }

        public DateTime? DateNais { get; set; }

        public string? Nomprenom { get; set; }

        public string? LieuNais { get; set; }

        public string? CodeGenr { get; set; }

        public string? EtatSante { get; set; }

        public string? Nompere { get; set; }

        public string? CodenatPere { get; set; }

        public string? NumeCin { get; set; }

        public string? Profession { get; set; }

        public string? NumTel { get; set; }

        public string? CodeComm { get; set; }

        public string? CodeDele { get; set; }

        public string? AdrePers { get; set; }

        public string? CodePost { get; set; }

        public string? EtatFamille { get; set; }

        public string? CodeEtab { get; set; }

        public string? CodeTypeEtab { get; set; }

        public string? CodeDeleEtab { get; set; }

        public string? CodeCommEtab { get; set; }

        public int? Anniscription { get; set; }

        public int? NbAnne { get; set; }

        public string? CodeutilAdd { get; set; }

        public DateTime? DateAjout { get; set; }

        public string? CodeutilUpdate { get; set; }

        public DateTime? Dateupdate { get; set; }

        public string? CodeutilSup { get; set; }

        public DateTime? Datesup { get; set; }

        public int? Activ { get; set; }

        public virtual NomenclatureCommune? CodeCommNavigation { get; set; }

        public virtual NomenclatureDelegation? CodeDeleNavigation { get; set; }

        public virtual NomenclatureTypeEtablissement? CodeTypeEtabNavigation { get; set; }
    }
}
