using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InfrastructureCaracteristiqueEspaceExterieur
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    /// <summary>
    /// خصائص الفضاء الخارجي
    /// </summary>
    public string CodeCaraEspaExte { get; set; } = null!;

    public virtual NomenclatureCaracteristiqueEspaceExterieur CodeCaraEspaExteNavigation { get; set; } = null!;

    public virtual EtablissementInfrastructure EtablissementInfrastructure { get; set; } = null!;
}
