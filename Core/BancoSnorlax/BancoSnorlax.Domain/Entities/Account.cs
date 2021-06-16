namespace BancoSnorlax.Domain.Entities
{
    public class Account
    {
        public int Id { get; init; }
        public int Agency { get; init; }
        public int Number { get; init; }
        public double Sale { get; set; }
        public double NegativeSale { get; init; } = 1000.00;
    }
}
