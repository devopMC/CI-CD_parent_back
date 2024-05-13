using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class MessageMessage
{
    public int IdMessage { get; set; }

    public DateTime? DateEnvoi { get; set; }

    public string CodeTypeM { get; set; } = null!;

    public string CodeUtilFrom { get; set; } = null!;

    public string? Titre { get; set; }

    public bool? Priority { get; set; }

    public string? Text { get; set; }

    public int? AnneScol { get; set; }

    public int? IdmessageParent { get; set; }

    public string? Codeutil { get; set; }

    public virtual NomenclatureTypeMessage CodeTypeMNavigation { get; set; } = null!;

    public virtual ICollection<MessageUser> MessageUsers { get; set; } = new List<MessageUser>();
}
