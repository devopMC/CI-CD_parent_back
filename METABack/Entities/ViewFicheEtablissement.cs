using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewFicheEtablissement
{
    public string CodeEtab { get; set; } = null!;

    public string? AdreEtab { get; set; }

    public string? CodePost { get; set; }

    public string CodeGouv { get; set; } = null!;

    public string? LibeGouv { get; set; }

    public string? CodeDele { get; set; }

    public string? LibeDele { get; set; }

    public string? TeleFixe { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? SiteWeb { get; set; }

    public string? CodePersDire { get; set; }

    public string? CodeOuveEtab { get; set; }

    public double? FraiInscParAnne { get; set; }

    public double? FraiMensActiNorm { get; set; }

    public double? FraiMensPepi { get; set; }

    public double? FraiMesuCont { get; set; }
}
