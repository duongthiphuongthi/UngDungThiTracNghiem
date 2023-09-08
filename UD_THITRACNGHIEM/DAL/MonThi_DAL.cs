using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DTO;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;
using System.Data;
using System.Data.SqlClient;

namespace UD_THITRACNGHIEM.DAL
{
    class MonThi_DAL
    {
        MonHocTableAdapter mt;
        DataConnect con;
        public MonThi_DAL()
        {
            mt = new MonHocTableAdapter();
            con = new DataConnect();
        }
        public bool Insert(MonThi_DTO a)
        {
            try
            {
                int i = (int)mt.KtraKhoa_MH(a.MaMH);
                if (i == 0)
                {
                    mt.InsertMH(a.MaMH, a.TenMH, a.TgLamBai, a.TongSoCau);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

    }
}
