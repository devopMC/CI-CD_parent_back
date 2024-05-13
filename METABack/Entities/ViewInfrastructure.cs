using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewInfrastructure
{
    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeTypeClot { get; set; }

    public string? LibeRegiProp { get; set; }

    public string? LibeTypeProp { get; set; }

    public string? LibeTypeConnInte { get; set; }

    public string? LibeEmplSieg { get; set; }

    public string? LibeCaraEspaExte { get; set; }

    public string? LibeEmpl { get; set; }

    public string? CodeGouv { get; set; }

    public string SurfTota { get; set; } = null!;

    public string SurfBati { get; set; } = null!;

    public string SurfEspaExte { get; set; } = null!;

    public string HautClot { get; set; } = null!;

    public string? Clot { get; set; }

    public string? PassSpecPersBesoSpec { get; set; }

    public string? TeleFixe { get; set; }

    public string? ConnInte { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? LibeComm { get; set; }

    public string? LibeDist { get; set; }

    public string LibeEtab { get; set; } = null!;

    public string? LibeEtatEtab { get; set; }

    public string LibeTypeEtatEtab { get; set; } = null!;

    public string? LibeSect { get; set; }

    public string? LibeZone { get; set; }

    public string Lib1 { get; set; } = null!;

    public string Lib2 { get; set; } = null!;

    public string Lib3 { get; set; } = null!;

    public string Lib4 { get; set; } = null!;

    public string Terrain { get; set; } = null!;

    public string SurfaceTerrain { get; set; } = null!;

    public string TypeTerrain { get; set; } = null!;
}
