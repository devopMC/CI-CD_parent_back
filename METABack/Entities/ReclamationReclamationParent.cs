using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ReclamationReclamationParent
{
    public int NumeRecl { get; set; }

    public string CodeEtab { get; set; } = null!;

    public string NomPren { get; set; } = null!;

    public string Cin { get; set; } = null!;

    public string? Email { get; set; }

    public string? Tele { get; set; }

    public DateTime DateRecl { get; set; }

    public string Sujet { get; set; } = null!;

    public string? CodeEtatRecl { get; set; }

    public string? CodePrio { get; set; }

    public string? Rapp { get; set; }

    public string? ObseDeci { get; set; }

    /// <summary>
    /// Code commerciale (Login)
    /// </summary>
    public string? Codeutil { get; set; }

    public virtual NomenclatureEtablissement CodeEtabNavigation { get; set; } = null!;

    public virtual NomenclatureEtatReclamation? CodeEtatReclNavigation { get; set; }

    public virtual NomenclaturePriorite? CodePrioNavigation { get; set; }

    public virtual SecuriteUtilisateur? CodeutilNavigation { get; set; }
}
