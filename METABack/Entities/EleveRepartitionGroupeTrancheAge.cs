using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveRepartitionGroupeTrancheAge
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public int? NombGrou { get; set; }

    public int? NombPersPourGrou { get; set; }

    public virtual NomenclatureTrancheAge CodeTranAgeNavigation { get; set; } = null!;

    public virtual ICollection<EleveRepartitionTrancheAge> EleveRepartitionTrancheAges { get; set; } = new List<EleveRepartitionTrancheAge>();

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
