using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveRepartitionTrancheAge
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public int NumeGrou { get; set; }

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public virtual EleveRepartitionGroupeTrancheAge EleveRepartitionGroupeTrancheAge { get; set; } = null!;
}
