using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureQualite
{
    /// <summary>
    /// Code qualite
    /// </summary>
    public string CodeQual { get; set; } = null!;

    /// <summary>
    /// Libellé qualite (Arabe)
    /// </summary>
    public string? LibeQual { get; set; }

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
