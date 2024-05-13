using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureNiveauEtude
{
    /// <summary>
    /// Code Niveau d&apos;Etude
    /// </summary>
    public string CodeNiveEtud { get; set; } = null!;

    /// <summary>
    /// Libellé Niveau d&apos;Etude (Arabe)
    /// </summary>
    public string LibeNiveEtud { get; set; } = null!;

    /// <summary>
    /// Order d&apos;affichage
    /// </summary>
    public int OrdrAffi { get; set; }

    /// <summary>
    /// Actif (Oui/Non)
    /// </summary>
    public bool? Acti { get; set; }

    public virtual ICollection<EleveRepartitionNiveauEtudeMere> EleveRepartitionNiveauEtudeMeres { get; set; } = new List<EleveRepartitionNiveauEtudeMere>();

    public virtual ICollection<EleveRepartitionNiveauEtudePere> EleveRepartitionNiveauEtudePeres { get; set; } = new List<EleveRepartitionNiveauEtudePere>();

    public virtual ICollection<NomenclatureEtablissement> NomenclatureEtablissements { get; set; } = new List<NomenclatureEtablissement>();

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
