using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeEspace
{
    /// <summary>
    /// Code Type Equipement
    /// </summary>
    public string CodeTypeEspa { get; set; } = null!;

    /// <summary>
    /// Libellée Type Equipement
    /// </summary>
    public string? LibeTypeEspa { get; set; }

    public string? CaraEspa { get; set; }

    /// <summary>
    /// Ordre d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementEspace> EtablissementEspaces { get; set; } = new List<EtablissementEspace>();

    public virtual ICollection<NomenclatureCaracteristiqueEspace> NomenclatureCaracteristiqueEspaces { get; set; } = new List<NomenclatureCaracteristiqueEspace>();
}
