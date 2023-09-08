using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.DAL
{
    class GiangVien_DAL
    {
        GiangVienTableAdapter gv;
        public GiangVien_DAL()
        {
            gv = new GiangVienTableAdapter();
        }
    }
}
