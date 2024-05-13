using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeInscription
{
    /// <summary>
    /// Code Type Equipement
    /// </summary>
    public string CodeTypeInsc { get; set; } = null!;

    /// <summary>
    /// Libellée Type Equipement
    /// </summary>
    public string? LibeTypeInsc { get; set; }

    /// <summary>
    /// Ordre d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionTypeInscription> EleveRepartitionTypeInscriptions { get; set; } = new List<EleveRepartitionTypeInscription>();
}
