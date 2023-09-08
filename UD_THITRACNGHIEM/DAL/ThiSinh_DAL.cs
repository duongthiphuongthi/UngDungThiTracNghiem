using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.DAL
{
    class ThiSinh_DAL
    {

        ThiSinhTableAdapter ts;
        DataConnect con;
        public ThiSinh_DAL()
        {
            ts = new ThiSinhTableAdapter();
            con = new DataConnect();
        }
        public List<ThiSinh_DTO> ThongtinTS(string maTS)
        {
            DataTable dt = ts.GetDataBy_ThongtinTS(maTS);
            List<ThiSinh_DTO> k = con.ListTable<ThiSinh_DTO>(dt);
            return k;
        }
        public bool InsertThiSinh(ThiSinh_DTO a)
        {
            try
            {
                int i = (int)ts.KtraKhoa(a.MaTS);
                if (i == 0)
                {
                    ts.Insert(a.MaTS, a.MaLop, a.TenTS, a.TenDN, a.NgaySinh);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteThiSinh(ThiSinh_DTO a)
        {
            try
            {
                int i = (int)ts.KtraKhoa(a.MaTS);
                if (i == 0)
                {
                    ts.XoaTaiKhoan_TS(a.TenDN);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdateThiSinh(ThiSinh_DTO a)
        {
            try
            {
                int i = (int)ts.KtraKhoa(a.MaTS);
                if (i == 0)
                {
                    ts.Update(a.MaTS, a.MaLop, a.TenTS, a.TenDN, a.NgaySinh);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool ktraKhoa(ThiSinh_DTO a)
        {
            try
            {
                int i = (int)ts.KtraKhoa(a.MaTS);
                if (i == 0)
                {
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
