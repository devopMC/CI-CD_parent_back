using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementEquipement
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeEqui { get; set; } = null!;

    public int? Nomb { get; set; }

    public bool? ConfCara { get; set; }

    public bool? Disp { get; set; }

    public string? Obse { get; set; }

    public bool ConfCaraType { get; set; }

    public bool DispType { get; set; }

    public string? ObseType { get; set; }

    public virtual NomenclatureEquipement CodeEquiNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
