using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementEnfantNe
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int Idenfant { get; set; }

    public DateTime Dateinscrit { get; set; }

    public DateTime? Datearret { get; set; }

    public string? Motifarret { get; set; }

    public DateTime? Datecreation { get; set; }

    public string? Codeutiladd { get; set; }

    public DateTime? DateMod { get; set; }

    public string? CodeutilMod { get; set; }

    public bool? Activ { get; set; }
}
