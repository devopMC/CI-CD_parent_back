using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementEspace
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public int NumeEspa { get; set; }

    /// <summary>
    /// Code Type Equipement
    /// </summary>
    public string CodeTypeEspa { get; set; } = null!;

    public double? Surf { get; set; }

    public double? Haut { get; set; }

    public string? Obse { get; set; }

    public virtual NomenclatureTypeEspace CodeTypeEspaNavigation { get; set; } = null!;

    public virtual ICollection<EtablissementEspaceCaracteristiqueEspace> EtablissementEspaceCaracteristiqueEspaces { get; set; } = new List<EtablissementEspaceCaracteristiqueEspace>();

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
