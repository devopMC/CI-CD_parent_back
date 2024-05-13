using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveEleveHandicap
{
    public int NumeElev { get; set; }

    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    public string? NomPren { get; set; }

    /// <summary>
    /// Code genre
    /// </summary>
    public string CodeGenr { get; set; } = null!;

    public DateTime? DateNais { get; set; }

    public string CodeTypeHand { get; set; } = null!;

    public string CodeDegrHand { get; set; } = null!;

    public string CodeInteHand { get; set; } = null!;

    public bool? SuiviCentSpec { get; set; }

    public int? AnneNais { get; set; }

    public virtual NomenclatureDedreHandicap CodeDegrHandNavigation { get; set; } = null!;

    public virtual NomenclatureGenre CodeGenrNavigation { get; set; } = null!;

    public virtual NomenclatureIntergrationHandicap CodeInteHandNavigation { get; set; } = null!;

    public virtual NomenclatureTypeHandicap CodeTypeHandNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
