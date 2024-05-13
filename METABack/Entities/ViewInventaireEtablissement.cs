using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInventaireEtablissement
{
    public string CodeEtab { get; set; } = null!;

    public string LibeEtab { get; set; } = null!;

    public string CodeTypeEtab { get; set; } = null!;

    public string? LibeTypeEtab { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeGouv { get; set; }

    public string CodeDele { get; set; } = null!;

    public string? LibeDele { get; set; }

    public string? AdreEtab { get; set; }

    public string? CodePost { get; set; }

    public string? MatrFisc { get; set; }

    public string CodeSect { get; set; } = null!;

    public string? LibeSect { get; set; }

    public string CodeZone { get; set; } = null!;

    public string? LibeZone { get; set; }

    public string? NumeDeciOuve { get; set; }

    public DateTime? DateDemaActi { get; set; }

    public DateTime? DateDeciOuve { get; set; }

    public DateTime? DateDepoCahiChar { get; set; }

    public DateTime? DateCrea { get; set; }

    public string? NomPrenFond { get; set; }

    public string CodeGenr { get; set; } = null!;

    public string? LibeGenr { get; set; }

    public string? NumePiecIden { get; set; }

    public DateTime? DateDeliv { get; set; }

    public DateTime? DateNaisFond { get; set; }

    public string? LieuNaisFond { get; set; }

    public string? AdrePersFond { get; set; }

    public string? CodePostFond { get; set; }

    public string CodeNiveEtud { get; set; } = null!;

    public string LibeNiveEtud { get; set; } = null!;

    public string CodeDipl { get; set; } = null!;

    public string? LibeDipl { get; set; }

    public string CodeSituFami { get; set; } = null!;

    public string? LibeSituFami { get; set; }

    public int? NombEnfa { get; set; }

    public string? Prof { get; set; }

    public string? Tele { get; set; }

    public string? Email { get; set; }

    public string? CodeEtatEtab { get; set; }
}
