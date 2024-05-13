using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureDedreHandicap
{
    public string CodeDegrHand { get; set; } = null!;

    public string? LibeDegrHand { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EleveEleveHandicap> EleveEleveHandicaps { get; set; } = new List<EleveEleveHandicap>();
}
