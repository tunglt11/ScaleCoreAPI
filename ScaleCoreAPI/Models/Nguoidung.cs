using System;
using System.Collections.Generic;

namespace ScaleCoreAPI.Models
{
    public partial class Nguoidung
    {
        public string MaNd { get; set; }
        public string MaLoai { get; set; }
        public string TenNd { get; set; }
        public string TenDnhap { get; set; }
        public string MatKhau { get; set; }
        public string Pin { get; set; }

        public virtual Loainguoidung MaLoaiNavigation { get; set; }
    }
}
