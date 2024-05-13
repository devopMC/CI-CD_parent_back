using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewFormationRapport
{
    public int Codeformation { get; set; }

    public DateTime? Dateformation { get; set; }

    public string? LieurFormation { get; set; }

    public string? SujetFormation { get; set; }

    public string? NomprenutilInsp { get; set; }

    public string? PerOrg { get; set; }

    public string? Nomformateur { get; set; }

    public string? Activiteformation { get; set; }

    public string? Observation { get; set; }

    public string? LibeGouv { get; set; }
}
