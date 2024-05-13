using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class InspectionFichierJoint
{
    public int NumeVisiInsp { get; set; }

    public string CodeEtab { get; set; } = null!;

    public int AnneScol { get; set; }

    public int NumeFichJoin { get; set; }

    public string PhysNameFile { get; set; } = null!;

    public string UploNameFile { get; set; } = null!;

    public string CodeUtil { get; set; } = null!;

    public DateTime DateOper { get; set; }
}
