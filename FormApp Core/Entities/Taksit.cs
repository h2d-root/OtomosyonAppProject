﻿namespace FormApp_Core.Entities
{
    public class Taksit : IEntity
    {
        public int Id { get; set; }
        public int SatisId { get; set; }
        public int MusteriId { get; set; }
        public int VadeSayisi { get; set; }
        public decimal TaksitTutari { get; set; }
    }
}
