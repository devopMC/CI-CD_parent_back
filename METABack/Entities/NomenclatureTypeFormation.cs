using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureTypeFormation
{
    public string CodeTypeForm { get; set; } = null!;

    public string? LibeTypeForm { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<PersonnelFormationContinue> PersonnelFormationContinues { get; set; } = new List<PersonnelFormationContinue>();
}
