namespace Projem.Models
{
    public class Urun
    {
        public Guid Id { get; set; }
        public string Isim { get; set; }
        public string Renk { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Stok { get; set; }
        public int Satilan { get; set; }
        public decimal AlisTutar { get; set; }
        public decimal SatisTutar { get; set; }
    }
}
