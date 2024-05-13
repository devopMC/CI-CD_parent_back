using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureRevenuMensuel
{
    /// <summary>
    /// Code genre
    /// </summary>
    public string CodeReveMens { get; set; } = null!;

    /// <summary>
    /// Libellé genre (Arabe)
    /// </summary>
    public string? LibeReveMens { get; set; }

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
