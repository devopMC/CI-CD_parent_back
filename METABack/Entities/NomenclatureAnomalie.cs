using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureAnomalie
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeAnom { get; set; } = null!;

    public string LibeAnom { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<EtablissementAnomalie> EtablissementAnomalies { get; set; } = new List<EtablissementAnomalie>();

    public virtual ICollection<InspectionVisiteInspection> InspectionVisiteInspections { get; set; } = new List<InspectionVisiteInspection>();
}
