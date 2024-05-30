﻿using EccomerceBlazorWasm.Models.Product;

namespace EccomerceBlazorWasm.Models.CreateModel
{
    public class ProductCreateModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public int? StateId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Price { get; set; }
        public decimal? Cost { get; set; }
        public int? Existence { get; set; }
        public int? ProductBrandId { get; set; }
        public int? ProductCategoryId { get; set; }

        public List<ProductPhotoViewModel>? Photos { get; set; }
        public ProductSpecificationViewModel? Specifications { get; set; }
    }
}
