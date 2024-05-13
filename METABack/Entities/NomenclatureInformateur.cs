namespace METABack.Entities;

public class NomenclatureInformateur
{
    public string CodeInformateur { get; set; } = null!;

    public string? LibeInformateur { get; set; }

    public int? OrdrAffi { get; set; }

    public bool? Acti { get; set; }

    public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
}
