using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class PersonnelPersonnel
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int IdenUniq { get; set; }

    public string? IdenUniqMatrCnss { get; set; }

    /// <summary>
    /// NomPren
    /// </summary>
    public string NomPren { get; set; } = null!;

    public string? CodeGenr { get; set; }

    public DateTime? DateNais { get; set; }

    public string? LieuNais { get; set; }

    public string? NumeCin { get; set; }

    public DateTime? DateCin { get; set; }

    /// <summary>
    /// Niveau d&apos;Etude
    /// </summary>
    public string? CodeNiveEtud { get; set; }

    /// <summary>
    /// Spécialité
    /// </summary>
    public string? CodeDipl { get; set; }

    /// <summary>
    /// Situation familiale
    /// </summary>
    public string? CodeSituFami { get; set; }

    public string? AdrePers { get; set; }

    public string? CodePost { get; set; }

    /// <summary>
    /// Délégation
    /// </summary>
    public string? CodeDele { get; set; }

    /// <summary>
    /// Grade
    /// </summary>
    public string? CodeGrad { get; set; }

    /// <summary>
    /// Code qualité
    /// </summary>
    public string? CodeQual { get; set; }

    /// <summary>
    /// Code Fonction
    /// </summary>
    public string? CodeFonc { get; set; }

    /// <summary>
    /// Anciennete (Année)
    /// </summary>
    public double? Anci { get; set; }

    /// <summary>
    /// Code corps
    /// </summary>
    public string? CodeCorp { get; set; }

    /// <summary>
    /// Spécialiste
    /// </summary>
    public bool? Spec { get; set; }

    /// <summary>
    /// Eligible
    /// </summary>
    public bool? Elig { get; set; }

    /// <summary>
    /// Code genre
    /// </summary>
    public string? CodeReveMens { get; set; }

    /// <summary>
    /// Complément information
    /// </summary>
    public string? CompInfo { get; set; }

    public string? CodeSituProf { get; set; }

    public string? TelGsm { get; set; }

    public string? Email { get; set; }

    public string? StructureAttache { get; set; }

    public DateTime? Daterecrutement { get; set; }

    public DateTime? Dateaffectation { get; set; }

    public DateTime? Daterespons { get; set; }

    public string? NotePead { get; set; }

    public DateTime? DatenotePead { get; set; }

    public string? AnotePead { get; set; }

    public string? AdatenotePead { get; set; }

    public virtual NomenclatureCorp? CodeCorpNavigation { get; set; }

    public virtual NomenclatureDelegation? CodeDeleNavigation { get; set; }

    public virtual NomenclatureDiplome? CodeDiplNavigation { get; set; }

    public virtual NomenclatureFonction? CodeFoncNavigation { get; set; }

    public virtual NomenclatureGenre? CodeGenrNavigation { get; set; }

    public virtual NomenclatureGrade? CodeGradNavigation { get; set; }

    public virtual NomenclatureNiveauEtude? CodeNiveEtudNavigation { get; set; }

    public virtual NomenclatureQualite? CodeQualNavigation { get; set; }

    public virtual NomenclatureRevenuMensuel? CodeReveMensNavigation { get; set; }

    public virtual NomenclatureSituationProfessionel? CodeSituProfNavigation { get; set; }

    public virtual ICollection<PersonnelFormationContinue> PersonnelFormationContinues { get; set; } = new List<PersonnelFormationContinue>();
}
