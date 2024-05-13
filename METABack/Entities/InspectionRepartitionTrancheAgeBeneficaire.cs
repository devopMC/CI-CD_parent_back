using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionRepartitionTrancheAgeBeneficaire
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeTranAge { get; set; }

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public int? NombTota { get; set; }

    public string? CodeTranAge { get; set; }
}
