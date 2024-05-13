using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionElevePresent
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeElevePresent { get; set; } = null!;

    public string? LibeElevePresent { get; set; }

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public int? NombTota { get; set; }
}
