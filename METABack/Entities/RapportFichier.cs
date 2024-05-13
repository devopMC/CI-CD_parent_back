using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class RapportFichier
{
    public int CodeFichier { get; set; }

    public int? Code { get; set; }

    public int? TypeRapport { get; set; }

    public string? NomFichier { get; set; }

    public string? Extension { get; set; }

    public byte[]? Data { get; set; }
}
