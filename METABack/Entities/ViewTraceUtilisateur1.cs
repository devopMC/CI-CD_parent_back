using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewTraceUtilisateur1
{
    public string? CodeGouv { get; set; }

    public string? LibeGouv { get; set; }

    public string Matr { get; set; } = null!;

    public string Nomprenutil { get; set; } = null!;

    public string Libegrouutil { get; set; } = null!;

    public decimal Numetrac { get; set; }

    public string? Libetrac { get; set; }

    public DateTime Datetrac { get; set; }

    public string Libeenti { get; set; } = null!;

    public string Libepack { get; set; } = null!;

    public string Libetypeopertrac { get; set; } = null!;

    public string? MoisTrac { get; set; }

    public string? JourTrac { get; set; }

    public string? JourSemaTrac { get; set; }

    public string QuarTrac { get; set; } = null!;
}
