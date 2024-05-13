using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypePropriete
{
    public string CodeTypeProp { get; set; } = null!;

    public string? LibeTypeProp { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementInfrastructure> EtablissementInfrastructures { get; set; } = new List<EtablissementInfrastructure>();
}
