namespace Alimbio.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string? NomService { get; set; }
        public string? Description { get; set; }

        public ICollection<Salarie>? Salaries { get; set; }
    }
}
