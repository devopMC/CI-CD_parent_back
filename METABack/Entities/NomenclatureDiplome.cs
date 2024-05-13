using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureDiplome
{
    /// <summary>
    /// Code diplome
    /// </summary>
    public string CodeDipl { get; set; } = null!;

    /// <summary>
    /// Libellé diplome (Arabe)
    /// </summary>
    public string? LibeDipl { get; set; }

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int? OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
