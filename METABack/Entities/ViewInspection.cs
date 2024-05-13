using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspection
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? Matr { get; set; }

    public string? Nomprenutil { get; set; }

    public string? Libegrouutil { get; set; }

    public DateTime? DateVisiInsp { get; set; }

    public string? LibeTypeInsp { get; set; }

    public string? DeduGene { get; set; }

    public string? CodeCommFonc { get; set; }

    public string? RemaSuivSujet { get; set; }

    public string? RemaSuivPers { get; set; }

    public string? RemaSuivInfr { get; set; }

    public string? RemaSuivActi { get; set; }

    public string? RemaSuivCondSecu { get; set; }

    public string? RemaSuivProgPeda { get; set; }

    public string? JustDeciFerm { get; set; }

    public int? DateLimiCorr { get; set; }

    public string? DetaAnom { get; set; }
}
