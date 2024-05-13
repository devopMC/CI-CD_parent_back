using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureProfession
{
    /// <summary>
    /// Code Type Equipement
    /// </summary>
    public string CodeProf { get; set; } = null!;

    /// <summary>
    /// Libellée Type Equipement
    /// </summary>
    public string LibeProf { get; set; } = null!;

    /// <summary>
    /// Ordre d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionProfessionMere> EleveRepartitionProfessionMeres { get; set; } = new List<EleveRepartitionProfessionMere>();

    public virtual ICollection<EleveRepartitionProfessionPere> EleveRepartitionProfessionPeres { get; set; } = new List<EleveRepartitionProfessionPere>();
}
