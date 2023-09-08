using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.DAL
{
    class CauHoi_DAL
    {
        CauHoiTableAdapter ch;
        DataConnect con;
        public CauHoi_DAL()
        {
            ch = new CauHoiTableAdapter();
            con = new DataConnect();
        }
        public List<CauHoi_DTO> getdata()
        {
            return con.ListTable<CauHoi_DTO>(ch.GetData());
        }
        public bool Insert(CauHoi_DTO a)
        {
            try
            {
                int i = (int)ch.KtraKhoa_CH(a.MaCH);
                if (i == 0)
                {
                    ch.Insert(a.MaCH,  a.NoiDung,a.MaMH);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool Delete(CauHoi_DTO a)
        {
            try
            {
                int i = (int)ch.KtraKhoa_CH(a.MaCH);
                if (i == 0)
                {
                    ch.Delete(a.MaCH, a.NoiDung, a.MaMH);
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
