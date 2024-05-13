using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRepartitionEnfantNe
{
    public int Idenfant { get; set; }

    public string? CodeGouv { get; set; }

    public int? AnneScol { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeDist { get; set; }

    public string? LibeEtab { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeSect { get; set; }

    public string? CodeEtab { get; set; }

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? Nomprenom { get; set; }

    public string? Nompere { get; set; }

    public string? Libegenr { get; set; }

    public string? LibeEtatFam { get; set; }

    public DateTime? DateNais { get; set; }

    public string? NumTel { get; set; }

    public string? LibeNaturePere { get; set; }

    public string? NumeCin { get; set; }

    public string? Profession { get; set; }

    public string? AdrePers { get; set; }

    public string? LieuNais { get; set; }

    public string? CodePost { get; set; }

    public string? EtatSante { get; set; }

    public string EtatEnfant { get; set; } = null!;

    public DateTime? Dateinscrit { get; set; }

    public DateTime? Datearret { get; set; }

    public string? Motifarret { get; set; }
}
