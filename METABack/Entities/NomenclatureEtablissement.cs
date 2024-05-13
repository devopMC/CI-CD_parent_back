namespace METABack.Entities
{
    public class NomenclatureEtablissement
    {
        /// <summary>
        /// Code établissement
        /// </summary>
        public string CodeEtab { get; set; } = null!;

        /// <summary>
        /// Libellé établissement
        /// </summary>
        public string LibeEtab { get; set; } = null!;

        /// <summary>
        /// Type établissement
        /// </summary>
        public string CodeTypeEtab { get; set; } = null!;

        public string? MatrFisc { get; set; }

        /// <summary>
        /// Secteur
        /// </summary>
        public string CodeSect { get; set; } = null!;

        /// <summary>
        /// Zone habitation
        /// </summary>
        public string? CodeZoneHabi { get; set; }

        /// <summary>
        /// Délégation
        /// </summary>
        public string? CodeDele { get; set; }

        public string? CodeCommEtab { get; set; }

        /// <summary>
        /// Numéro du décision d&apos;ouverture
        /// </summary>
        public string? NumeDeciOuve { get; set; }

        /// <summary>
        /// La date du démarage de l&apos;activité
        /// </summary>
        public DateTime? DateDemaActi { get; set; }

        /// <summary>
        /// Date du décision d&apos;ouverture
        /// </summary>
        public DateTime? DateDeciOuve { get; set; }
        public DateTime? DateDepoCahiChar { get; set; }

        public bool DepoCahiCharPrep { get; set; }
        public DateTime? DateCrea { get; set; }
        public DateTime? DateCreaBd { get; set; }
        public string? NomPrenFond { get; set; }
        public string? CodeGenrFond { get; set; }
        public string? NumePiecIden { get; set; }
        public DateTime? DateDeliv { get; set; }
        public DateTime? DateNaisFond { get; set; }
        public string? LieuNaisFond { get; set; }
        public string? AdrePersFond { get; set; }
        public string? CodePostFond { get; set; }
        public string? CodeDeleFond { get; set; }
        public string? CodeComm { get; set; }

        public string? CodeNiveEtud { get; set; }

        /// <summary>
        /// Diplome
        /// </summary>
        public string? CodeDipl { get; set; }

        /// <summary>
        /// Code genre
        /// </summary>
        public string? CodeSituFami { get; set; }

        /// <summary>
        /// Nombre d&apos;enfant
        /// </summary>
        public int? NombEnfa { get; set; }

        /// <summary>
        /// Profession
        /// </summary>
        public string? Prof { get; set; }

        /// <summary>
        /// Téléphone
        /// </summary>
        public string? Tele { get; set; }

        /// <summary>
        /// E-mail
        /// </summary>
        public string? Email { get; set; }

        public int? NumeEtab { get; set; }

        public string? CodeEtatEtab { get; set; }

        public string? AdreEtab { get; set; }

        public string? CodePostEtab { get; set; }

        public string? CodeMiniFond { get; set; }

        public DateTime? DateFerm { get; set; }

        public string? CausFerm { get; set; }

        public string? UserFerm { get; set; }

        public DateTime? DateValFerm { get; set; }

        public virtual NomenclatureCommune? CodeCommNavigation { get; set; }

        public virtual NomenclatureDelegation? CodeDeleFondNavigation { get; set; }

        public virtual NomenclatureDelegation? CodeDeleNavigation { get; set; }

        public virtual NomenclatureDiplome? CodeDiplNavigation { get; set; }

        public virtual NomenclatureNiveauEtude? CodeNiveEtudNavigation { get; set; }

        public virtual NomenclatureSecteur CodeSectNavigation { get; set; } = null!;

        public virtual NomenclatureSituationFamiliale? CodeSituFamiNavigation { get; set; }

        public virtual NomenclatureTypeEtablissement CodeTypeEtabNavigation { get; set; } = null!;

        public virtual NomenclatureZone? CodeZoneHabiNavigation { get; set; }

        public virtual ICollection<EtablissementFicheEtablissement> EtablissementFicheEtablissements { get; set; } = new List<EtablissementFicheEtablissement>();

        public virtual ICollection<ReclamationReclamationParent> ReclamationReclamationParents { get; set; } = new List<ReclamationReclamationParent>();

        public virtual ICollection<SecuriteUtilisateur> Codeutils { get; set; } = new List<SecuriteUtilisateur>();
    }
}
