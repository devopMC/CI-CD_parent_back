using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SignalisationFichierRpt
{
    public int CodeFichier { get; set; }

    public int? CodeSignalisation { get; set; }

    public string? NomFichier { get; set; }

    public string? Extension { get; set; }

    public byte[]? Data { get; set; }
}
