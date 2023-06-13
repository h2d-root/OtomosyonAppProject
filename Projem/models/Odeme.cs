namespace Projem.Models
{
    public class Odeme
    {
        public int Id { get; set; }
        public int TaksitId { get; set; }
        public int MusteriId { get; set; }
        public string OdemeTarihi { get; set; }
        public decimal OdemeTutarı { get; set; }
    }

}
