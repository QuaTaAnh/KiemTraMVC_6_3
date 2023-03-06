﻿using System;
using System.Collections.Generic;

namespace KiemTra6_3.Models;

public partial class THangSx
{
    public string MaHangSx { get; set; } = null!;

    public string? HangSx { get; set; }

    public string? MaNuocThuongHieu { get; set; }

    public virtual ICollection<TDanhMucSp> TDanhMucSps { get; } = new List<TDanhMucSp>();
}
