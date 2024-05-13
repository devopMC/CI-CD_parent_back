using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeEquipement
{
    public string CodeTypeEqui { get; set; } = null!;

    public string? LibeTypeEqui { get; set; }

    /// <summary>
    /// Ordre d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureEquipement> NomenclatureEquipements { get; set; } = new List<NomenclatureEquipement>();
}
