using crqs.example.domain.Enties.ValueObjects;

namespace Cars.Application.Outuput.DTO
{
    public record CarDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; }
        public Stats Info { get; init; }
    }
}
