using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class NomenclatureOrganisationAdministrative
{
    /// <summary>
    /// Commune
    /// </summary>
    public string CodeOrgaAdmi { get; set; } = null!;

    public string LibeOrgaAdmi { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    /// <summary>
    /// Code type établissement
    /// </summary>
    public string? CodeTypeEtab { get; set; }

    public virtual NomenclatureTypeEtablissement? CodeTypeEtabNavigation { get; set; }

    public virtual ICollection<EtablissementOrganisationAdministrative> EtablissementOrganisationAdministratives { get; set; } = new List<EtablissementOrganisationAdministrative>();
}
