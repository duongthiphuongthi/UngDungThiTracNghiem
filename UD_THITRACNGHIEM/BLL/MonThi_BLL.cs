using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UD_THITRACNGHIEM.DAL;
using UD_THITRACNGHIEM.DTO;

namespace UD_THITRACNGHIEM.BLL
{
    class MonThi_BLL
    {
        MonThi_DAL dal;
        public MonThi_BLL()
        {
            dal = new MonThi_DAL();
        }
        public bool Insert(MonThi_DTO a)
        {
            return dal.Insert(a);
        }
    }
}
