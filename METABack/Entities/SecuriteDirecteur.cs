namespace METABack.Entities;

public class SecuriteDirecteur
{
    public int Id { get; set; }
    public string? Login { get; set; }
    public string? Pwd { get; set; }
    public string? Nom { get; set; }
    public string? Prenom { get; set; }
    public string? CodeEtab { get; set; }
    public string? Role { get; set; }
    public int Etat { get; set; }
}
