using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class NomenclatureCaracteristiqueEspaceExterieur
{
    /// <summary>
    /// خصائص الفضاء الخارجي
    /// </summary>
    public string CodeCaraEspaExte { get; set; } = null!;

    public string? LibeCaraEspaExte { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }
}
