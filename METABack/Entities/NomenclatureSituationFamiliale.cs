using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureSituationFamiliale
{
    /// <summary>
    /// Code genre
    /// </summary>
    public string CodeSituFami { get; set; } = null!;

    /// <summary>
    /// Libellé genre (Arabe)
    /// </summary>
    public string? LibeSituFami { get; set; }

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
