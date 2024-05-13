using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureCaracteristiqueEspace
{
    public string CodeCaraEspa { get; set; } = null!;

    public string? LibeCaraEspa { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeTypeEspa { get; set; }

    public virtual NomenclatureTypeEspace? CodeTypeEspaNavigation { get; set; }

    public virtual ICollection<EtablissementEspaceCaracteristiqueEspace> EtablissementEspaceCaracteristiqueEspaces { get; set; } = new List<EtablissementEspaceCaracteristiqueEspace>();
}
