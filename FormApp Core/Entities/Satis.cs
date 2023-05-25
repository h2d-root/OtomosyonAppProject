namespace FormApp_Core.Entities
{
    public class Satis : IEntity
    {
        public int Id { get; set; }
        public Guid BarkodId { get; set; }
        public int MusteriId { get; set; }
        public int Adet { get; set; }
        public decimal Tutar { get; set; }
        public string SatisTarihi { get; set; }

    }
}
