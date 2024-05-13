using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureEmplacementSiege
{
    public string CodeEmplSieg { get; set; } = null!;

    public string? LibeEmplSieg { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementInfrastructure> EtablissementInfrastructures { get; set; } = new List<EtablissementInfrastructure>();
}
