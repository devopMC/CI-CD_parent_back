using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class MessageGroupe
{
    public int IdMessage { get; set; }

    public string CodeGroup { get; set; } = null!;

    public string? CodeGouv { get; set; }

    public string Observation { get; set; } = null!;

    public virtual MessageMessage IdMessageNavigation { get; set; } = null!;
}
