using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewRapportEvent
{
    public long? RowNumber { get; set; }

    public int CodeEvent { get; set; }

    public string? Codegouv { get; set; }

    public int? Annescol { get; set; }

    public string? CodeSecFor { get; set; }

    public string? NomEvent { get; set; }

    public string? CodeNivFor { get; set; }

    public DateTime? DateEvent { get; set; }

    public string? OrgEvent { get; set; }

    public string? LieuEvent { get; set; }

    public int? NbFemmeC { get; set; }

    public int? NbHommeC { get; set; }

    public int? NbFemmeE { get; set; }

    public int? NbHommeE { get; set; }

    public string? PrixEvent { get; set; }

    public string? InvesEvent { get; set; }

    public DateTime? Daterapport { get; set; }

    public string? Codeutilrapport { get; set; }

    public string? ActiviteEvent { get; set; }

    public string? Observation { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }

    public string? LibesecFor { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeNivFor { get; set; }

    public string? LibeNatInv { get; set; }

    public string? Participant { get; set; }
}
