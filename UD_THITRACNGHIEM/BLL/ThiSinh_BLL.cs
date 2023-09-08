using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.BLL
{
    class ThiSinh_BLL
    {
        ThiSinh_DAL dal;
        public ThiSinh_BLL()
        {
            dal = new ThiSinh_DAL();
        }
        public bool Insert(ThiSinh_DTO a)
        {
            return dal.InsertThiSinh(a);
        }
        public bool Delete(ThiSinh_DTO a)
        {
            return dal.DeleteThiSinh(a);
        }
        public bool Update(ThiSinh_DTO a)
        {
            return dal.UpdateThiSinh(a);
        }
        public bool Check(ThiSinh_DTO a)
        {
            return dal.ktraKhoa(a);
        }
        public List<ThiSinh_DTO> ThongtinTS(string ma)
        {
            return dal.ThongtinTS(ma);
        }
    }
}
