namespace crqs.example.domain.Enties.ValueObjects
{
    public record Stats
    {
        public Stats(decimal price, int year, string description)
        {
            this.Price = price;
            this.Year = year;
            this.Description = description;
        }

        public decimal Price { get; private set; }
        public int Year { get; private set; }
        public string Description { get; private set; } = string.Empty;

    }
}
