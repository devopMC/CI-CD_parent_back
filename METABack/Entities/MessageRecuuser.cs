using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class MessageRecuuser
{
    public int Idmessage { get; set; }

    public string CodeUtil { get; set; } = null!;

    public DateTime? Daterecu { get; set; }
}
