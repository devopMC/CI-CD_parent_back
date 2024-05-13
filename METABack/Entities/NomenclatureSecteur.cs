using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureSecteur
{
    /// <summary>
    /// Code secteur
    /// </summary>
    public string CodeSect { get; set; } = null!;

    /// <summary>
    /// Libellé secteur (Arabe)
    /// </summary>
    public string? LibeSect { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();
}
