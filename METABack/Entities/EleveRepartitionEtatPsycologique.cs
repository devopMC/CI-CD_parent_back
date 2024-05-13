using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveRepartitionEtatPsycologique
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public string CodeEtatPsyc { get; set; } = null!;

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public virtual NomenclatureEtatPsycologique CodeEtatPsycNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
