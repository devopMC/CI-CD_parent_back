using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionVisiteInspection
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string MatrInsp { get; set; } = null!;

    public DateTime? DateVisiInsp { get; set; }

    public string? CodeTypeInsp { get; set; }

    public string? DeduGene { get; set; }

    public string? CodeEtabPers { get; set; }

    public int? AnneScolPers { get; set; }

    public int? IdenUniqPers { get; set; }

    public DateTime? DateProcVisi { get; set; }

    public double? Note { get; set; }

    public string? NoteEnLettre { get; set; }

    public string? RemaSuivSujet { get; set; }

    public string? RemaSuivPers { get; set; }

    public string? RemaSuivInfr { get; set; }

    public string? RemaSuivActi { get; set; }

    public string? RemaSuivCondSecu { get; set; }

    public string? RemaSuivProgPeda { get; set; }

    public int? NombEnfaInscMasc { get; set; }

    public int? NombEnfaInscFemi { get; set; }

    public int? NombEnfaPresMasc { get; set; }

    public int? NombEnfaPresFemi { get; set; }

    public string? VisiPerSuivActi { get; set; }

    public string? JustDeciFerm { get; set; }

    public int? DateLimiCorr { get; set; }

    public string? MembCommTitu { get; set; }

    public string? DetaAnom { get; set; }

    public DateTime? Datesaisie { get; set; }

    public string? CodeEtatEtab { get; set; }

    public string? RemarqueInsp { get; set; }

    public int? Statut { get; set; }

    public string? Inspecteurvalide { get; set; }

    public DateTime? Datevalidation { get; set; }

    public string? Chefvue { get; set; }

    public DateTime? Datevue { get; set; }

    public string? Capacite { get; set; }

    public DateTime? Datemail { get; set; }

    public string? Inspecteur2 { get; set; }

    public string? CodeActivite { get; set; }

    public string? PriseRemaq { get; set; }

    public DateTime? DatedemandeMaj { get; set; }

    public DateTime? DateconfirmationMaj { get; set; }

    public string? CodeutilConfirmation { get; set; }

    public int? DemandeMaj { get; set; }

    public string? MotifMaj { get; set; }

    public string? FinSaisie { get; set; }

    public virtual NomenclatureTypeInspection? CodeTypeInspNavigation { get; set; }

    public virtual ICollection<InspectionConstatation> InspectionConstatations { get; set; } = new List<InspectionConstatation>();

    public virtual ICollection<InspectionDeductionCategorieRubriqueInspection> InspectionDeductionCategorieRubriqueInspections { get; set; } = new List<InspectionDeductionCategorieRubriqueInspection>();

    public virtual ICollection<InspectionEquipement> InspectionEquipements { get; set; } = new List<InspectionEquipement>();

    public virtual ICollection<InspectionEspace> InspectionEspaces { get; set; } = new List<InspectionEspace>();

    public virtual InspectionInfoGenerale? InspectionInfoGenerale { get; set; }

    public virtual ICollection<InspectionNombreEnfantTrancheAge> InspectionNombreEnfantTrancheAges { get; set; } = new List<InspectionNombreEnfantTrancheAge>();

    public virtual ICollection<InspectionRecification> InspectionRecifications { get; set; } = new List<InspectionRecification>();

    public virtual ICollection<InspectionRepartitionHandicap> InspectionRepartitionHandicaps { get; set; } = new List<InspectionRepartitionHandicap>();

    public virtual ICollection<InspectionRepartitionPersonelFonction> InspectionRepartitionPersonelFonctions { get; set; } = new List<InspectionRepartitionPersonelFonction>();

    public virtual ICollection<InspectionRepartitionTrancheAge> InspectionRepartitionTrancheAges { get; set; } = new List<InspectionRepartitionTrancheAge>();

    public virtual ICollection<NomenclatureAnomalie> CodeAnoms { get; set; } = new List<NomenclatureAnomalie>();
}
