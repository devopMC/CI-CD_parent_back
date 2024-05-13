using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementHistoriqueEtatEtab
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeEtatEtab { get; set; } = null!;

    public DateTime? DateModif { get; set; }

    public bool? CreationEtatb { get; set; }

    public bool? ChangementAdresse { get; set; }

    public string? AdresseEtablissement { get; set; }

    public bool? ChangementDitecteur { get; set; }

    public string? Cinresponsable { get; set; }

    public string? Codeutilisateur { get; set; }
}
