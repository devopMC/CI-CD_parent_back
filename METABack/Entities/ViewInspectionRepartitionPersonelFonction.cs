using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionRepartitionPersonelFonction
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeFonc { get; set; }

    public int? NombMasc { get; set; }

    public int? NombFemi { get; set; }

    public int? NombTota { get; set; }
}
