using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureGrade
{
    public string CodeGrad { get; set; } = null!;

    public string? LibeGrad { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelPersonnel> PersonnelPersonnel { get; set; } = new List<PersonnelPersonnel>();
}
