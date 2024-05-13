using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class ActiviteFiche
{
    public int CodeAct { get; set; }

    public string? Codegouv { get; set; }

    public int? Annescol { get; set; }

    public string? CodeSecFor { get; set; }

    public string? CodeNatAct { get; set; }

    public DateTime? DateAct { get; set; }

    public string? SujetAct { get; set; }

    public string? LieuAct { get; set; }

    public int? NbFemme { get; set; }

    public int? NbHomme { get; set; }

    public string? Typepart { get; set; }

    public DateTime? Daterapport { get; set; }

    public string? Codeutilrapport { get; set; }

    public string? ActiviteAct { get; set; }

    public string? Observation { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutil { get; set; }

    public DateTime? Datemodification { get; set; }

    public string? CodeutilM { get; set; }
}
