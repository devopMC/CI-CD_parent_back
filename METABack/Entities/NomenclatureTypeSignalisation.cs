namespace METABack.Entities
{
    public class NomenclatureTypeSignalisation
    {
        public string CodeTypeSignalisation { get; set; } = null!;

        public string? LibeTypeSignalisation { get; set; }

        public int? OrdrAffi { get; set; }

        public bool? Acti { get; set; }

        public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
    }
}
