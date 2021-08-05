using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTTH_Tuan6._1.Modules
{
    class XLNHANVIEN : XLBANG
    {
        public XLNHANVIEN() : base("NHANVIEN") { }
        public XLNHANVIEN(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
