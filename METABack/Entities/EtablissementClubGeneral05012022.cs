using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementClubGeneral05012022
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public string? PrixClub { get; set; }

    public int? NbInscrit { get; set; }
}
