using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ReclamationReclamation
{
    public int NumeRecl { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? NomPrenPersRecl { get; set; }

    public DateTime? DateRecl { get; set; }

    public string? Sujet { get; set; }

    public string? Affe { get; set; }

    public string? Rapp { get; set; }

    public string? ObseDeci { get; set; }

    public string? CodeEtatRecl { get; set; }

    public string? CodePrio { get; set; }

    public virtual NomenclatureEtatReclamation? CodeEtatReclNavigation { get; set; }

    public virtual NomenclaturePriorite? CodePrioNavigation { get; set; }

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
