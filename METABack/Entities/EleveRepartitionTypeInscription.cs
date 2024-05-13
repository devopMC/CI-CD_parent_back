using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EleveRepartitionTypeInscription
{

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string CodeTypeInsc { get; set; } = null!;

    public int? NombFemi { get; set; }

    public int? NombMasc { get; set; }

    public virtual NomenclatureTypeInscription CodeTypeInscNavigation { get; set; } = null!;

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
