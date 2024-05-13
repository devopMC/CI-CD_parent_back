using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclaturePriorite
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodePrio { get; set; } = null!;

    public string? LibePrio { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<ReclamationReclamationParent> ReclamationReclamationParents { get; set; } = new List<ReclamationReclamationParent>();

    public virtual ICollection<ReclamationReclamation> ReclamationReclamations { get; set; } = new List<ReclamationReclamation>();
}
