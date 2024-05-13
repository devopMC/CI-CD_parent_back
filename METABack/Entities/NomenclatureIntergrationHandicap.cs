using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureIntergrationHandicap
{
    public string CodeInteHand { get; set; } = null!;

    public string? LibeInteHand { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveEleveHandicap> EleveEleveHandicaps { get; set; } = new List<EleveEleveHandicap>();
}
