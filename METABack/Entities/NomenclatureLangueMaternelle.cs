using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureLangueMaternelle
{
    /// <summary>
    /// Code Niveau d&apos;Etude
    /// </summary>
    public string CodeLangMate { get; set; } = null!;

    /// <summary>
    /// Libellé Niveau d&apos;Etude (Arabe)
    /// </summary>
    public string LibeLangMate { get; set; } = null!;

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionLangueMaternelle> EleveRepartitionLangueMaternelles { get; set; } = new List<EleveRepartitionLangueMaternelle>();
}
