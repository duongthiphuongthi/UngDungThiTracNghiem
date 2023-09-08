using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.BLL
{
    class CauHoi_BLL
    {
        CauHoi_DAL dal;
        public CauHoi_BLL()
        {
            dal = new CauHoi_DAL();
        }
        public bool Insert(CauHoi_DTO a)
        {
            return dal.Insert(a);
        }
        public bool Delete(CauHoi_DTO a)
        {
            return dal.Delete(a);
        }
    }
}
