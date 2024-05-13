namespace METABack.Entities
{
    public class NomenclatureConcerne
    {
        public string CodeConcerne { get; set; } = null!;

        public string? LibeConcerne { get; set; }

        public int? OrdrAffi { get; set; }

        public bool? Acti { get; set; }

        public virtual ICollection<NomenclatureSignalisation> NomenclatureSignalisations { get; set; } = new List<NomenclatureSignalisation>();
    }
}
