using System;
using System.Collections.Generic;

namespace ScaleCoreAPI.Models
{
    public partial class Phieucan
    {
        public string Id { get; set; }
        public string MaPhieu { get; set; }
        public string Bsx { get; set; }
        public string KhachHang { get; set; }
        public string LoaiHang { get; set; }
        public decimal? KlcanLan1 { get; set; }
        public decimal? KlcanLan2 { get; set; }
        public string KieuCanLan1 { get; set; }
        public string KieuCanLan2 { get; set; }
        public DateTime? NgayCanLan1 { get; set; }
        public DateTime? NgayCanLan2 { get; set; }
        public string TenNhanVienCanLan1 { get; set; }
        public string TenNhanVienCanLan2 { get; set; }
        public string MaNhanVienCanLan1 { get; set; }
        public string MaNhanVienCanLan2 { get; set; }
        public string LaiXe { get; set; }
        public decimal? DonGia { get; set; }
        public decimal? LanIn { get; set; }
        public string CheDoCan { get; set; }
        public byte[] Cam1 { get; set; }
        public byte[] Cam2 { get; set; }
        public byte[] Cam3 { get; set; }
        public byte[] BienSoXe { get; set; }
    }
}
