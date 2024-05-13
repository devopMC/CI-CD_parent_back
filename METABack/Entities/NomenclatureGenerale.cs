using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureGenerale
{
    public string Pays { get; set; } = null!;

    public string? Ministere { get; set; }

    public string? Region { get; set; }

    public string? Direction { get; set; }

    public string? Signature { get; set; }

    public int? Nbjourupdate { get; set; }

    public int? NbjourSup { get; set; }

    public int? NbjourupdateSignalisation { get; set; }

    public int? NbjourSupSignalisation { get; set; }

    public string? DelaiInspection { get; set; }

    public int? Nbjoursaisieinsp { get; set; }

    public int? NbjourupdateRapport { get; set; }

    public int? NbjoursupRapport { get; set; }

    public int? NbjourupdateEnfant { get; set; }
}
