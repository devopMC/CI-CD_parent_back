using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionStat
{
    public string? Code { get; set; }

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

    public string? CodeComm { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeDele { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeGouv { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeEtab { get; set; }

    public int? AnneVisiInsp { get; set; }

    public string? MoisVisiInsp { get; set; }

    public string? JourVisiInsp { get; set; }

    public string? JourSemaVisiInsp { get; set; }

    public string QuarVisiInsp { get; set; } = null!;

    public string? LibeRect { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string? LibeDist { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? LibeSect { get; set; }

    public string? LibeZone { get; set; }

    public string Personnel { get; set; } = null!;

    public string? NomInspecteur2 { get; set; }
}
