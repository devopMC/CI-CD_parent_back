using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewMessageDetail
{
    public int IdMessage { get; set; }

    public DateTime? DateEnvoi { get; set; }

    public string CodeTypeM { get; set; } = null!;

    public string CodeUtilFrom { get; set; } = null!;

    public string Titre { get; set; } = null!;

    public bool? Priority { get; set; }

    public string? Text { get; set; }

    public string? Mail { get; set; }

    public string LibeTypeM { get; set; } = null!;

    public string NomPrenUtil { get; set; } = null!;

    public DateTime? Datereception { get; set; }

    public string? Codeutil { get; set; }

    public int? AnneScol { get; set; }

    public int? IdmessageParent { get; set; }

    public int Lu { get; set; }
}
