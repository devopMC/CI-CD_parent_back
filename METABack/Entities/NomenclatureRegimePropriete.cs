using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureRegimePropriete
{
    public string CodeRegiProp { get; set; } = null!;

    public string? LibeRegiProp { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementInfrastructure> EtablissementInfrastructures { get; set; } = new List<EtablissementInfrastructure>();
}
