using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRessourceHumain
{
    public int IdenUniq { get; set; }

    public string? IdenUniqMatrCnss { get; set; }

    public string NomPren { get; set; } = null!;

    public string? NumeCin { get; set; }

    public DateTime? DateCin { get; set; }

    public string? LibeGenr { get; set; }

    public int? DateNais { get; set; }

    public string? LibeNiveEtud { get; set; }

    public string? LibeDipl { get; set; }

    public string? LibeSituFami { get; set; }

    public string? LibeFonc { get; set; }

    public string? LibeQual { get; set; }

    public string? LibeGrad { get; set; }

    public double? Anci { get; set; }

    public bool? Spec { get; set; }

    public bool? Elig { get; set; }

    public string? LibeCorp { get; set; }

    public string? LibeReveMens { get; set; }

    public string? LibeDelePers { get; set; }

    public string? LibeGouvPers { get; set; }

    public string? LibeDistPers { get; set; }

    public string? LibeDeleEtab { get; set; }

    public string? LibeGouvEtab { get; set; }

    public string? LibeDistEtab { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeGouv { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeSect { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeEtatEtab { get; set; }

    public string? LibeSituProf { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? LibeCommEtab { get; set; }

    public string HasIdenUniqMatrCnss { get; set; } = null!;

    public string? AdrePers { get; set; }

    public string? TelGsm { get; set; }

    public string? Email { get; set; }

    public DateTime? Daterecrutement { get; set; }

    public DateTime? Dateaffectation { get; set; }

    public DateTime? Daterespons { get; set; }

    public string? NotePead { get; set; }

    public DateTime? DatenotePead { get; set; }

    public string? LibeStruAtta { get; set; }

    public string? MoisRec { get; set; }

    public int? AnneRec { get; set; }

    public string? MoisAff { get; set; }

    public int? AnneAff { get; set; }

    public string? MoisRes { get; set; }

    public int? AnneRes { get; set; }

    public string? Cadreinspection { get; set; }
}
