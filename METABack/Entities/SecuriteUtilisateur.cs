using System;
using System.Collections.Generic;

namespace METABack.Entities;

public partial class SecuriteUtilisateur
{
    /// <summary>
    /// Code commerciale (Login)
    /// </summary>
    public string Codeutil { get; set; } = null!;

    /// <summary>
    /// Mot de passe
    /// </summary>
    public string? Motpassutil { get; set; }

    /// <summary>
    /// Matricule
    /// </summary>
    public string Matr { get; set; } = null!;

    /// <summary>
    /// Nom et prénom
    /// </summary>
    public string Nomprenutil { get; set; } = null!;

    /// <summary>
    /// Téléphone / GSM
    /// </summary>
    public string? Tele { get; set; }

    public string? Gsm { get; set; }

    public string? Email { get; set; }

    public string? SkypeId { get; set; }

    /// <summary>
    /// Groupe utilisateur
    /// </summary>
    public string Codegrouutil { get; set; } = null!;

    /// <summary>
    /// Niveau hierarchique
    /// </summary>
    public string? Codenivehier { get; set; }

    /// <summary>
    /// Date de dernier MAJ
    /// </summary>
    public DateTime? Datemaj { get; set; }

    /// <summary>
    /// Code type standing
    /// </summary>
    public string? CodeCommFonc { get; set; }

    public bool? Etat { get; set; }

    public string? CodeGouv { get; set; }

    public string? CodeUtilPare { get; set; }

    public string? Codeutiladd { get; set; }

    public DateTime? Dateadduser { get; set; }

    public string? Codeutilupdate { get; set; }

    public DateTime? Dateupdateuser { get; set; }

    public string? CodeCerc { get; set; }

    public virtual SecuriteGroupeutilisateur CodegrouutilNavigation { get; set; } = null!;

    public virtual SecuriteNiveauhierarchique? CodenivehierNavigation { get; set; }

    public virtual ICollection<EtablissementAnomalie> EtablissementAnomalies { get; set; } = new List<EtablissementAnomalie>();

    public virtual ICollection<ReclamationReclamationParent> ReclamationReclamationParents { get; set; } = new List<ReclamationReclamationParent>();

    public virtual ICollection<SecuriteDroitaccesutilisateur> SecuriteDroitaccesutilisateurs { get; set; } = new List<SecuriteDroitaccesutilisateur>();

    public virtual SecuriteSessionUtilisateur? SecuriteSessionUtilisateur { get; set; }

    public virtual ICollection<SecuriteTraceutilisateur> SecuriteTraceutilisateurs { get; set; } = new List<SecuriteTraceutilisateur>();

    public virtual ICollection<NomenclatureEtablissement> CodeEtabs { get; set; } = new List<NomenclatureEtablissement>();
}
