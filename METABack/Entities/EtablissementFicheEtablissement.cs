using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementFicheEtablissement
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    /// <summary>
    /// Adresse de l&apos;établissement
    /// </summary>
    public string? AdreEtab { get; set; }

    /// <summary>
    /// Code postal
    /// </summary>
    public string? CodePost { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeComm { get; set; }

    /// <summary>
    /// Téléphone fixe
    /// </summary>
    public string? TeleFixe { get; set; }

    /// <summary>
    /// Fax
    /// </summary>
    public string? Fax { get; set; }

    /// <summary>
    /// Adresse électronique
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// Site web
    /// </summary>
    public string? SiteWeb { get; set; }

    /// <summary>
    /// Directeur de l&apos;établissement
    /// </summary>
    public string? CodePersDire { get; set; }

    public string? CodeOuveEtab { get; set; }

    /// <summary>
    /// Frais inscription par année
    /// </summary>
    public double? FraiInscParAnne { get; set; }

    /// <summary>
    /// Frais mensuel de l&apos;activité normale
    /// </summary>
    public double? FraiMensActiNorm { get; set; }

    /// <summary>
    /// Frais mensuel de l&apos;activité normale
    /// </summary>
    public double? FraiMensPepi { get; set; }

    /// <summary>
    /// Frais mensuel de l&apos;activité normale
    /// </summary>
    public double? FraiMesuCont { get; set; }

    public string? Capacite { get; set; }

    public string? HeureDebutS1 { get; set; }

    public string? HeureFinS1 { get; set; }

    public string? HeureDebutS2 { get; set; }

    public string? HeureFinS2 { get; set; }

    public bool? CreationEtatb { get; set; }

    public bool? ChangementAdresse { get; set; }

    public bool? ChangementDitecteur { get; set; }

    public virtual NomenclatureDelegation? CodeDeleNavigation { get; set; }

    public virtual NomenclatureEtablissement CodeEtabNavigation { get; set; } = null!;

    public virtual NomenclatureOuvertureEtablissement? CodeOuveEtabNavigation { get; set; }

    public virtual ICollection<EleveEleveHandicap> EleveEleveHandicaps { get; set; } = new List<EleveEleveHandicap>();

    public virtual ICollection<EleveRepartitionEtatParent> EleveRepartitionEtatParents { get; set; } = new List<EleveRepartitionEtatParent>();

    public virtual ICollection<EleveRepartitionEtatPsycologique> EleveRepartitionEtatPsycologiques { get; set; } = new List<EleveRepartitionEtatPsycologique>();

    public virtual ICollection<EleveRepartitionEtatSante> EleveRepartitionEtatSantes { get; set; } = new List<EleveRepartitionEtatSante>();

    public virtual ICollection<EleveRepartitionGroupeTrancheAge> EleveRepartitionGroupeTrancheAges { get; set; } = new List<EleveRepartitionGroupeTrancheAge>();

    public virtual ICollection<EleveRepartitionLangueMaternelle> EleveRepartitionLangueMaternelles { get; set; } = new List<EleveRepartitionLangueMaternelle>();

    public virtual ICollection<EleveRepartitionNationalite> EleveRepartitionNationalites { get; set; } = new List<EleveRepartitionNationalite>();

    public virtual ICollection<EleveRepartitionNiveauEtudeMere> EleveRepartitionNiveauEtudeMeres { get; set; } = new List<EleveRepartitionNiveauEtudeMere>();

    public virtual ICollection<EleveRepartitionNiveauEtudePere> EleveRepartitionNiveauEtudePeres { get; set; } = new List<EleveRepartitionNiveauEtudePere>();

    public virtual ICollection<EleveRepartitionNiveauSalaire> EleveRepartitionNiveauSalaires { get; set; } = new List<EleveRepartitionNiveauSalaire>();

    public virtual ICollection<EleveRepartitionProfessionMere> EleveRepartitionProfessionMeres { get; set; } = new List<EleveRepartitionProfessionMere>();

    public virtual ICollection<EleveRepartitionProfessionPere> EleveRepartitionProfessionPeres { get; set; } = new List<EleveRepartitionProfessionPere>();

    public virtual ICollection<EleveRepartitionTrancheAgeArretEtude> EleveRepartitionTrancheAgeArretEtudes { get; set; } = new List<EleveRepartitionTrancheAgeArretEtude>();

    public virtual ICollection<EleveRepartitionTrancheAgeBeneficaire> EleveRepartitionTrancheAgeBeneficaires { get; set; } = new List<EleveRepartitionTrancheAgeBeneficaire>();

    public virtual ICollection<EleveRepartitionTrancheAgeTypePriseEnCharge> EleveRepartitionTrancheAgeTypePriseEnCharges { get; set; } = new List<EleveRepartitionTrancheAgeTypePriseEnCharge>();

    public virtual ICollection<EleveRepartitionTypeInscription> EleveRepartitionTypeInscriptions { get; set; } = new List<EleveRepartitionTypeInscription>();

    public virtual ICollection<EleveRepartitionTypePriseEnCharge> EleveRepartitionTypePriseEnCharges { get; set; } = new List<EleveRepartitionTypePriseEnCharge>();

    public virtual ICollection<EtablissementAnomalie> EtablissementAnomalies { get; set; } = new List<EtablissementAnomalie>();

    public virtual ICollection<EtablissementEquipement> EtablissementEquipements { get; set; } = new List<EtablissementEquipement>();

    public virtual ICollection<EtablissementEspace> EtablissementEspaces { get; set; } = new List<EtablissementEspace>();

    public virtual EtablissementInfrastructure? EtablissementInfrastructure { get; set; }

    public virtual ICollection<EtablissementInfrastructureAutre> EtablissementInfrastructureAutres { get; set; } = new List<EtablissementInfrastructureAutre>();

    public virtual ICollection<EtablissementIntervention> EtablissementInterventions { get; set; } = new List<EtablissementIntervention>();

    public virtual ICollection<ReclamationReclamation> ReclamationReclamations { get; set; } = new List<ReclamationReclamation>();
}
