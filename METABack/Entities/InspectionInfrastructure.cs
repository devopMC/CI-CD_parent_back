using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionInfrastructure
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeEmplSieg { get; set; }

    public string? AutrEmplSieg { get; set; }

    public string? CodeEmplSieg { get; set; }

    public string? LibeTypeProp { get; set; }

    public double? SurfTota { get; set; }

    public double? SurfBati { get; set; }

    public double? SurfEspaExte { get; set; }

    public string? LibeTypeClot { get; set; }

    public bool? Clot { get; set; }

    public double? HautClot { get; set; }

    public bool? PassSpecPersBesoSpec { get; set; }

    public bool? TeleFixe { get; set; }

    public string? LibeTypeConnInte { get; set; }

    public string? LibeCaraEspaExte { get; set; }

    public string? LibeEmpl { get; set; }

    public bool? ExistTerrain { get; set; }

    public string? SurfaceTerrain { get; set; }

    public string? LibeTerrain { get; set; }

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
