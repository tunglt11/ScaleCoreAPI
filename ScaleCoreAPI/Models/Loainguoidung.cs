using System;
using System.Collections.Generic;

namespace ScaleCoreAPI.Models
{
    public partial class Loainguoidung
    {
        public Loainguoidung()
        {
            Nguoidung = new HashSet<Nguoidung>();
        }

        public string MaLoai { get; set; }
        public string TenLoaiNd { get; set; }

        public virtual ICollection<Nguoidung> Nguoidung { get; set; }
    }
}
