namespace METABack.Entities
{
    public class NomenclatureTypeEtablissement
    {
        /// <summary>
        /// Code type établissement
        /// </summary>
        public string CodeTypeEtab { get; set; } = null!;

        /// <summary>
        /// Libellé type établissement (Arabe)
        /// </summary>
        public string? LibeTypeEtab { get; set; }

        /// <summary>
        /// Order d&apos;affichage
        /// </summary>
        public int? OrdrAffi { get; set; }

        /// <summary>
        /// Actif (Oui/Non)
        /// </summary>
        public bool? Acti { get; set; }

        public string? Formulaire { get; set; }

        public string? CodeFormulaire { get; set; }

        public virtual ICollection<EnfantNecessite> EnfantNecessites { get; set; } = new List<EnfantNecessite>();

        public virtual ICollection<NomenclatureCategorieRubriqueInspection> NomenclatureCategorieRubriqueInspections { get; set; } = new List<NomenclatureCategorieRubriqueInspection>();

        public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();

        public virtual ICollection<NomenclatureOrganisationAdministrative> NomenclatureOrganisationAdministratives { get; set; } = new List<NomenclatureOrganisationAdministrative>();

        public virtual ICollection<NomenclatureOrganisationPedagogique> NomenclatureOrganisationPedagogiques { get; set; } = new List<NomenclatureOrganisationPedagogique>();
    }
}
