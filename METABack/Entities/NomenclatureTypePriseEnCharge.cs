using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypePriseEnCharge
{
    /// <summary>
    /// Code Niveau d&apos;Etude
    /// </summary>
    public string CodeTypePrisChar { get; set; } = null!;

    /// <summary>
    /// Libellé Niveau d&apos;Etude (Arabe)
    /// </summary>
    public string LibeTypePrisChar { get; set; } = null!;

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionTrancheAgeTypePriseEnCharge> EleveRepartitionTrancheAgeTypePriseEnCharges { get; set; } = new List<EleveRepartitionTrancheAgeTypePriseEnCharge>();

    public virtual ICollection<EleveRepartitionTypePriseEnCharge> EleveRepartitionTypePriseEnCharges { get; set; } = new List<EleveRepartitionTypePriseEnCharge>();
}
