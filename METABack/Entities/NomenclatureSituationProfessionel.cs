using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureSituationProfessionel
{
    public string CodeSituProf { get; set; } = null!;

    public string? LibeSituProf { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
