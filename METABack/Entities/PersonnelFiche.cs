using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class PersonnelFiche
{
    public string? NumeCin { get; set; }

    public DateTime? DateCin { get; set; }

    public string NomPren { get; set; } = null!;

    public string? CodeGenr { get; set; }

    public DateTime? DateNais { get; set; }

    public string? LieuNais { get; set; }

    public string? IdenUniqMatrCnss { get; set; }

    public string? CodeNiveEtud { get; set; }

    public string? CodeDipl { get; set; }

    public string? CodeSituFami { get; set; }

    public string? AdrePers { get; set; }

    public string? CodePost { get; set; }

    public string? CodeDele { get; set; }

    public string? CodeGrad { get; set; }

    public string? CodeQual { get; set; }

    public double? Anci { get; set; }

    public string? CodeCorp { get; set; }

    public bool? Spec { get; set; }

    public bool? Elig { get; set; }

    public string? CodeReveMens { get; set; }

    public string? CompInfo { get; set; }

    public string? TelGsm { get; set; }

    public string? Email { get; set; }

    public string? StructureAttache { get; set; }

    public DateTime? Daterecrutement { get; set; }

    public DateTime? Dateaffectation { get; set; }

    public DateTime? Daterespons { get; set; }

    public string? NotePead { get; set; }

    public DateTime? DatenotePead { get; set; }

    public string? AnotePead { get; set; }

    public string? AdatenotePead { get; set; }

    public string? Codeutiladd { get; set; }
}
