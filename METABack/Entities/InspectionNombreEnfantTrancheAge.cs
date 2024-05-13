using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionNombreEnfantTrancheAge
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTranAge { get; set; } = null!;

    public int? NombEnfa { get; set; }

    public virtual NomenclatureTrancheAge CodeTranAgeNavigation { get; set; } = null!;

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
