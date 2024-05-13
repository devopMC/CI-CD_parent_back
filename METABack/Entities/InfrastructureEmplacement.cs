using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InfrastructureEmplacement
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
    public string CodeEmpl { get; set; } = null!;

    public virtual NomenclatureEmplacementEtablissement CodeEmplNavigation { get; set; } = null!;

    public virtual EtablissementInfrastructure EtablissementInfrastructure { get; set; } = null!;
}
