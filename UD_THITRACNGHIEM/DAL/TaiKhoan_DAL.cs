using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DTO;
using UD_THITRACNGHIEM.DAL.UD_THITRACNGHIEMTableAdapters;


namespace UD_THITRACNGHIEM.DAL
{
    class TaiKhoan_DAL
    {
        TaiKhoanTableAdapter tk;
        public TaiKhoan_DAL()
        {
            tk = new TaiKhoanTableAdapter();
        }
        //public bool Insert(TaiKhoan_DTO a)
        //{
        //    try
        //    {
        //        int i = (int)tk.KtraKhoa_TK(a.TenDN);
        //        if (i == 0)
        //        {
        //            tk.Insert();
        //            return true;
        //        }
        //        return false;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        public int kiemTraDN(TaiKhoan_DTO a)
        {
            try 
            { 
                int i = int.Parse(tk.KT_DN(a.TenDN, a.MKDN).ToString());
                return i;
            }
            catch
            {
                return -1;
            }

            //}

            //public bool Delete(TaiKhoan_DTO a)
            //{
            //    try
            //    {
            //        int i = (int)tk.KtraKhoa_TK(a.TenDN);
            //        if (i == 1)
            //        {
            //            tk.XoaTaiKhoan(a.TenDN);
            //            return true;
            //        }
            //        return false;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}
        }
    }
}
