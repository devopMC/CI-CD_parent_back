using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTrancheAge
{
    public string CodeTranAge { get; set; } = null!;

    public string? LibeTranAge { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeTypeEtab { get; set; }

    public virtual ICollection<EleveRepartitionGroupeTrancheAge> EleveRepartitionGroupeTrancheAges { get; set; } = new List<EleveRepartitionGroupeTrancheAge>();

    public virtual ICollection<EleveRepartitionTrancheAgeArretEtude> EleveRepartitionTrancheAgeArretEtudes { get; set; } = new List<EleveRepartitionTrancheAgeArretEtude>();

    public virtual ICollection<EleveRepartitionTrancheAgeBeneficaire> EleveRepartitionTrancheAgeBeneficaires { get; set; } = new List<EleveRepartitionTrancheAgeBeneficaire>();

    public virtual ICollection<EleveRepartitionTrancheAgeTypePriseEnCharge> EleveRepartitionTrancheAgeTypePriseEnCharges { get; set; } = new List<EleveRepartitionTrancheAgeTypePriseEnCharge>();

    public virtual ICollection<InspectionNombreEnfantTrancheAge> InspectionNombreEnfantTrancheAges { get; set; } = new List<InspectionNombreEnfantTrancheAge>();
}
