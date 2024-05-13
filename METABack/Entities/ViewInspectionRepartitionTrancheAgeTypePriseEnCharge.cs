using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionRepartitionTrancheAgeTypePriseEnCharge
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public string CodeTypePrisChar { get; set; } = null!;

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public string? LibeTranAge { get; set; }

    public string LibeTypePrisChar { get; set; } = null!;

    public int? NombTota { get; set; }
}
