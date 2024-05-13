using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInspectionRepartitionPersonel
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? IdenUniqMatrCnss { get; set; }

    public int IdenUniq { get; set; }

    public string NomPren { get; set; } = null!;

    public string? LibeGenr { get; set; }

    public DateTime? DateNais { get; set; }

    public string LibeNiveEtud { get; set; } = null!;

    public string? LibeGrad { get; set; }

    public string? LibeFonc { get; set; }

    public string? StructureAttache { get; set; }

    public DateTime? Daterecrutement { get; set; }

    public DateTime? Dateaffectation { get; set; }

    public DateTime? Daterespons { get; set; }

    public string? NotePead { get; set; }

    public string? DatenotePead { get; set; }
}
