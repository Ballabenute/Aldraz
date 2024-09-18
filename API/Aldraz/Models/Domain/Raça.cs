namespace Aldraz.Models.Domain
{
    public class Raça
    {
        public  Guid Id { get; set; }
        public required string Name { get; set; }
        public string? Description { get; set; }
    }
}
