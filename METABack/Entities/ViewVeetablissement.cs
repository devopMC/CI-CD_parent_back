using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewVeetablissement
{
    public int AnneScol { get; set; }

    public string CodeEtab { get; set; } = null!;

    public string LibeEtab { get; set; } = null!;

    public int? AnneDeciOuvr { get; set; }

    public string? MoisDeciOuvr { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeSect { get; set; }

    public string? LibeOuveEtab { get; set; }

    public double? FraiInscParAnne { get; set; }

    public double? FraiMensActiNorm { get; set; }

    public string? LieuNaisFond { get; set; }

    public string? LibeGenrFond { get; set; }

    public string? LibeDiplFond { get; set; }

    public string? LibeNiveEtudFond { get; set; }

    public string? LibeSituFamiFond { get; set; }

    public string? CodeGouv { get; set; }

    public string? CodeDele { get; set; }

    public string? Tele { get; set; }

    public string? CodePostEtab { get; set; }

    public string CodeTypeEtab { get; set; } = null!;

    public string? LibeDist { get; set; }

    public string? NomPrenFond { get; set; }

    public string? NumePiecIden { get; set; }

    public DateTime? DateDemaActi { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string? AdreEtab { get; set; }

    public string? LibeCommEtab { get; set; }

    public string? CodePost { get; set; }

    public DateTime? DateFerm { get; set; }

    public int? AnneFerm { get; set; }

    public string? MoisFerm { get; set; }

    public string QuarFerm { get; set; } = null!;

    public string? CausFerm { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;
}
