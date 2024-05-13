using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveRepartitionTrancheAgeOld02122020
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public int NumeGrou { get; set; }

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }
}
