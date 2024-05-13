using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureInterventionnecessaire
{
    public string CodeInterv { get; set; } = null!;

    public string? LibeInterv { get; set; }

    public string? CodeTypeInterv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementIntervention> EtablissementInterventions { get; set; } = new List<EtablissementIntervention>();
}
