using System;

namespace JewelryStore.Business
{
    public class ExportDto
    {
        public string FileContent { get; set; }
        public string Price { get; set; }
        public string Weight { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }
        public string FileName { get; set; }
    }
}
