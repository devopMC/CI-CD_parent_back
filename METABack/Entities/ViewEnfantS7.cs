using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewEnfantS7
{
    public string CodeTypeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? LibeGouv { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeDele { get; set; }

    public int? OrdrG { get; set; }

    public int? OrdrD { get; set; }

    public int? OrdrT { get; set; }

    public string? Libetranage { get; set; }

    public string Genre { get; set; } = null!;

    public string? Libegenr { get; set; }

    public int? Nombre { get; set; }
}
