using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementAnomalie
{
    public int Nume { get; set; }

    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public DateTime? DateVisi { get; set; }

    public string? DurePrisEnCharg { get; set; }

    public string? Obse { get; set; }

    /// <summary>
    /// Code commerciale (Login)
    /// </summary>
    public string Codeutil { get; set; } = null!;

    public virtual SecuriteUtilisateur CodeutilNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;

    public virtual ICollection<NomenclatureAnomalie> CodeAnoms { get; set; } = new List<NomenclatureAnomalie>();
}
