using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementOrganisationPedagogique
{
    public int NumeVisiInsp { get; set; }

    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    /// <summary>
    /// Commune
    /// </summary>
    public string CodeOrgaPeda { get; set; } = null!;

    public bool Disp { get; set; }

    public bool Ajour { get; set; }

    public virtual NomenclatureOrganisationPedagogique CodeOrgaPedaNavigation { get; set; } = null!;
}
