using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEquipement
{
    public string CodeEqui { get; set; } = null!;

    public string? LibeEqui { get; set; }

    public string? CaraEqui { get; set; }

    public string? CodeTypeEqui { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual NomenclatureTypeEquipement? CodeTypeEquiNavigation { get; set; }

    public virtual ICollection<EtablissementEquipement> EtablissementEquipements { get; set; } = new List<EtablissementEquipement>();
}
