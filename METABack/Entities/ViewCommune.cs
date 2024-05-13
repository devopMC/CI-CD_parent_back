using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewCommune
{
    public string CodeComm { get; set; } = null!;

    public string? LibeComm { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public string? CodeDele { get; set; }

    public string? LibeDele { get; set; }
}
