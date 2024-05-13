using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureTypeCloture
{
    /// <summary>
    /// خصائص الفضاء الخارجي
    /// </summary>
    public string CodeTypeClot { get; set; } = null!;

    public string? LibeTypeClot { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementInfrastructure> EtablissementInfrastructures { get; set; } = new List<EtablissementInfrastructure>();
}
