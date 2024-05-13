using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ParametrageColumnRechercheMultiCritere
{
    public int Id { get; set; }

    public int IdCube { get; set; }

    public string Name { get; set; } = null!;

    public string Caption { get; set; } = null!;

    public string? Area { get; set; }

    public int? AreaIndex { get; set; }

    public bool? Visi { get; set; }

    public string? SummaryType { get; set; }

    public string? CellFormatType { get; set; }

    public string? CellFormatString { get; set; }
}
