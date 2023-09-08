using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.BLL
{
    class TaiKhoan_BLL
    {
        TaiKhoan_DAL dal;
        public TaiKhoan_BLL()
        {
            dal = new TaiKhoan_DAL();
        }
        //public bool Insert(TaiKhoan_DTO a)
        //{
        //    return dal.Insert(a);
        //}
        public int kiemTraDN(TaiKhoan_DTO a)
        {
            return dal.kiemTraDN(a);
        }
    }
}
