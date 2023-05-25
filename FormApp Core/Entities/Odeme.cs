namespace FormApp_Core.Entities
{
    public class Odeme : IEntity
    {
        public int Id { get; set; }
        public int TaksitId { get; set; }
        public int MusteriId { get; set; }
        public string OdemeTarihi { get; set; }
        public decimal OdemeTutarı { get; set; }
    }

}
