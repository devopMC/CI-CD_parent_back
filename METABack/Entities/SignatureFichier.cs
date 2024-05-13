using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SignatureFichier
{
    public string? Codeutil { get; set; }

    public byte[]? Fichier { get; set; }
}
