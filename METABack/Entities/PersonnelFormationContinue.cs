using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class PersonnelFormationContinue
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    /// <summary>
    /// Identifiant du personnel
    /// </summary>
    public int IdenUniq { get; set; }

    /// <summary>
    /// Nume sequentielle
    /// </summary>
    public int NumeLign { get; set; }

    /// <summary>
    /// Type formation
    /// </summary>
    public string? CodeTypeForm { get; set; }

    /// <summary>
    /// Date formation
    /// </summary>
    public DateTime? DateForm { get; set; }

    /// <summary>
    /// Lieu  formation
    /// </summary>
    public string? LieuForm { get; set; }

    /// <summary>
    /// Organisme
    /// </summary>
    public string? Orga { get; set; }

    public double? PeriForm { get; set; }

    public string? SujetForm { get; set; }

    public virtual NomenclatureTypeFormation? CodeTypeFormNavigation { get; set; }

    public virtual PersonnelPersonnel PersonnelPersonnel { get; set; } = null!;
}
