using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementEspaceCaracteristiqueEspace
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

    public string CodeCaraEspa { get; set; } = null!;

    public bool ConfCara { get; set; }

    public virtual NomenclatureCaracteristiqueEspace CodeCaraEspaNavigation { get; set; } = null!;

    public virtual EtablissementEspace EtablissementEspace { get; set; } = null!;
}
