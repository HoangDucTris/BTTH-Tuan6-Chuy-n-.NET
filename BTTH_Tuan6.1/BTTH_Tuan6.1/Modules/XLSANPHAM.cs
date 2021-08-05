using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_Tuan6._1.Modules
{
    class XLSANPHAM : XLBANG
    {
        public XLSANPHAM() : base("SANPHAM") { }
        public XLSANPHAM(string pQuery) : base("SANPHAM", pQuery) { }
    }
}
