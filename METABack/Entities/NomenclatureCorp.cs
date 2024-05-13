using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureCorp
{
    /// <summary>
    /// Code corps
    /// </summary>
    public string CodeCorp { get; set; } = null!;

    /// <summary>
    /// Libellé corps(Arabe)
    /// </summary>
    public string? LibeCorp { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
