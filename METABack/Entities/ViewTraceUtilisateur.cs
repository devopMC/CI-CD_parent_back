using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewTraceUtilisateur
{
    public decimal Numetrac { get; set; }

    public string? Libetrac { get; set; }

    public string? Linktrac { get; set; }

    public string Codeutil { get; set; } = null!;

    public DateTime Datetrac { get; set; }

    public string Codetypeoper { get; set; } = null!;

    public string Codeenti { get; set; } = null!;

    public string Pkenti { get; set; } = null!;

    public string Nomprenutil { get; set; } = null!;

    public string Libepack { get; set; } = null!;

    public string Libeenti { get; set; } = null!;

    public string? LibeGouv { get; set; }
}
