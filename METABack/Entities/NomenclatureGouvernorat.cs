namespace METABack.Entities;

public class NomenclatureGouvernorat
{
    public string CodeGouv { get; set; } = null!;
    public string? LibeGouv { get; set; }
    public string? CodeDist { get; set; }
    public int? OrdrAffi { get; set; }
    public bool? Acti { get; set; }

    public virtual NomenclatureDistrict? CodeDistNavigation { get; set; }

    public virtual ICollection<NomenclatureDelegation> NomenclatureDelegations { get; set; } = new List<NomenclatureDelegation>();

    public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
}
