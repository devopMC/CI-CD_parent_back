using System;
using System.Collections.Generic;

namespace METABack.Entities;

public class EtablissementInfrastructure
{
    /// <summary>
    /// Code établissement
    /// </summary>
    public string CodeEtab { get; set; } = null!;

    /// <summary>
    /// Année scolaire
    /// </summary>
    public int AnneScol { get; set; }

    /// <summary>
    /// مقرّ المؤسسة
    /// </summary>
    public string? CodeEmplSieg { get; set; }

    /// <summary>
    /// غير ذلك حدده
    /// </summary>
    public string? AutrEmplSieg { get; set; }

    /// <summary>
    /// نوع العقار
    /// </summary>
    public string? CodeTypeProp { get; set; }

    /// <summary>
    /// ملكية العقار
    /// </summary>
    public string? CodeRegiProp { get; set; }

    /// <summary>
    /// المساحةالجملية
    /// </summary>
    public double? SurfTota { get; set; }

    /// <summary>
    /// المساحة المغطاة
    /// </summary>
    public double? SurfBati { get; set; }

    /// <summary>
    /// مساحة الفضاء الخارجي
    /// </summary>
    public double? SurfEspaExte { get; set; }

    /// <summary>
    /// المؤسسة محاطة بسياج
    /// </summary>
    public bool? Clot { get; set; }

    /// <summary>
    /// نوع السياج
    /// </summary>
    public string? CodeTypeClot { get; set; }

    /// <summary>
    /// ارتفاع السياج
    /// </summary>
    public double? HautClot { get; set; }

    /// <summary>
    /// يوجد ممر خاص بذوي الاحتياجات الخصوصية
    /// </summary>
    public bool? PassSpecPersBesoSpec { get; set; }

    /// <summary>
    /// هاتف قار
    /// </summary>
    public bool? TeleFixe { get; set; }

    /// <summary>
    /// المؤسسة مرتبطة بشبكة الأنترنات
    /// </summary>
    public bool? ConnInte { get; set; }

    public bool? ExistTerrain { get; set; }

    public string? SurfaceTerrain { get; set; }

    public string? CodeTypeTerrain { get; set; }

    public virtual NomenclatureEmplacementSiege? CodeEmplSiegNavigation { get; set; }

    public virtual NomenclatureRegimePropriete? CodeRegiPropNavigation { get; set; }

    public virtual NomenclatureTypeCloture? CodeTypeClotNavigation { get; set; }

    public virtual NomenclatureTypePropriete? CodeTypePropNavigation { get; set; }

    public virtual EtablissementFicheEtablissement EtablissementFicheEtablissement { get; set; } = null!;
}
