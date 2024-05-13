using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewNomenclatureDelegation2
{
    public string CodeDele { get; set; } = null!;

    public string? LibeDele { get; set; }

    public string? CodeGouv { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
