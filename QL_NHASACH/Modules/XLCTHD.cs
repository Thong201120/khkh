﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NHASACH.Modules
{
    class XLCTHD: XLBANG
    {
        public XLCTHD() : base("CTHD") { }
        public XLCTHD(string pQuery) : base("CTHD", pQuery) { }
    }
}
