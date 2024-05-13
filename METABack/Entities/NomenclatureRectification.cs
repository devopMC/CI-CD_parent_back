using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureRectification
{
    public string CodeRect { get; set; } = null!;

    public string? LibeRect { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<InspectionRecification> InspectionRecifications { get; set; } = new List<InspectionRecification>();
}
