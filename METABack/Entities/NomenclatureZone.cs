using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureZone
{
    /// <summary>
    /// Code zone (Urbain/rurale)
    /// </summary>
    public string CodeZone { get; set; } = null!;

    /// <summary>
    /// Libellé zone (Arabe)
    /// </summary>
    public string? LibeZone { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();
}
