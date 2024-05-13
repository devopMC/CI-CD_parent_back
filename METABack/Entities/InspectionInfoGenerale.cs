using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionInfoGenerale
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeEtab { get; set; }

    public string? LibeTypeEtab { get; set; }

    public string? LibeDele { get; set; }

    public string? LibeGouv { get; set; }

    public string? CodePost { get; set; }

    public string? AdreEtab { get; set; }

    public string? TeleFixe { get; set; }

    public string? LibeComm { get; set; }

    public string? NomPrenFond { get; set; }

    public string? NumePiecIden { get; set; }

    public DateTime? DateDepoCahiChar { get; set; }

    public bool DepoCahiCharPrep { get; set; }

    public DateTime? DateCrea { get; set; }

    public string? NomPrenDire { get; set; }

    public string? NumePiecIdenDire { get; set; }

    public string? Email { get; set; }

    public virtual InspectionVisiteInspection InspectionVisiteInspection { get; set; } = null!;
}
