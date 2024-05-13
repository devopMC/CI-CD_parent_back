using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class ParametrageCubeAnalyse
{
    public int Id { get; set; }

    public string NomCube { get; set; } = null!;

    public string Requ { get; set; } = null!;

    public int? OrdrAffi { get; set; }

    public bool Acti { get; set; }
}
