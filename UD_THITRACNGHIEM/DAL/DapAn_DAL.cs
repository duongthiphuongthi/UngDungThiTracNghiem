using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.DAL
{
    class DapAn_DAL
    {
        DapAnTableAdapter da;
        DataConnect con;
        public DapAn_DAL()
        {
            da = new DapAnTableAdapter();
            con = new DataConnect();
        }
        public List<DapAn_DTO> getdata_CH(string mach)
        {
            return con.ListTable<DapAn_DTO>(da.GetDataBy_CH(mach));
        }
        public bool Insert(List<DapAn_DTO> lst)
        {
            try
            {
                int i = (int)da.KtraKhoa_DA(lst[0].MaCH);
                foreach (var a in lst)
                {

                    if (i == 0)
                    {
                        da.Insert(a.MaDA, a.MaCH, a.NoiDung, a.DungSai);
                    }
                    else
                        return false;
                } return true;

            }
            catch
            {
                return false;
            }
        }
            public bool Delete( List<DapAn_DTO> lst)
        {
            try
            {
                int i = (int)da.KtraKhoa_DA(lst[0].MaCH);
                foreach(var a in lst)
                { 
                    
                    if (i == 0)
                    {
                        da.Delete(a.MaDA, a.MaCH, a.NoiDung, a.DungSai);
                    }
                    else
                        return false;
                } return true;

            }
            catch
            {
                return false;
            }
        }
    }
}
