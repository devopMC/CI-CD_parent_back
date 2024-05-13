using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ViewUtilisateur
{
    public string Codeutil { get; set; } = null!;

    public string? Motpassutil { get; set; }

    public string Matr { get; set; } = null!;

    public string Nomprenutil { get; set; } = null!;

    public string? Tele { get; set; }

    public string? Gsm { get; set; }

    public string? Email { get; set; }

    public string? SkypeId { get; set; }

    public string Codegrouutil { get; set; } = null!;

    public string? Codenivehier { get; set; }

    public DateTime? Datemaj { get; set; }

    public string? CodeCommFonc { get; set; }

    public bool Etat { get; set; }

    public string? CodeGouv { get; set; }

    public string? CodeUtilPare { get; set; }

    public string? LibeGouv { get; set; }

    public string Libegrouutil { get; set; } = null!;
}
