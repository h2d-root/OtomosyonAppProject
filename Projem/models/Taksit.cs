
namespace Projem.Models
{
    public class Taksit
    {
        public int Id { get; set; }
        public int SatisId { get; set; }
        public int MusteriId { get; set; }
        public int VadeSayisi { get; set; }
        public decimal TaksitTutari { get; set; }
    }
}
