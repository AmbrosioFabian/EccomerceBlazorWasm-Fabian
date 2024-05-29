﻿namespace EccomerceBlazorWasm.Models.CreateModel
{
    public class LossCreateModel
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Total { get; set; }

        public int? StateId { get; set; }

        public decimal? UnitCost { get; set; }
        public int? Amount { get; set; }
        public string Description { get; set; } = string.Empty;
        public int? ProductId { get; set; }
        public int? LossReasonId { get; set; }
    }
}
