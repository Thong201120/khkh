using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHASACH.Modules
{
    class XLSANPHAM : XLBANG
    {
        public XLSANPHAM() : base("NHANVIEN") { }
        public XLSANPHAM(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
