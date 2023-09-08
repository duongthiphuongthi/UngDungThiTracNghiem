using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.BLL
{
    class DapAn_BLL
    {
        DapAn_DAL dal;
        public DapAn_BLL()
        {
            dal = new DapAn_DAL();
        }
        public bool Insert(List<DapAn_DTO> a)
        {
            return dal.Insert(a);
        }
        public bool Delete(List<DapAn_DTO> a)
        {
            return dal.Delete(a);
        }
    }
}
