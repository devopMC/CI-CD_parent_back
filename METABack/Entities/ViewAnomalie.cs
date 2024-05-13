using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewAnomalie
{
    public string CodeAnom { get; set; } = null!;

    public string Libeanom { get; set; } = null!;

    public string? LibeDele { get; set; }

    public string? Libegouv { get; set; }

    public string? LibeDist { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeGouv { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeZone { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeSect { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? LibeCommEtab { get; set; }

    public string? DetaAnom { get; set; }

    public DateTime? DatefinAn { get; set; }
}
