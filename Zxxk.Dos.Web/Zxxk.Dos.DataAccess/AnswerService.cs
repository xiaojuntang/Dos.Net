using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zxxk.Dos.DataModel;

namespace Zxxk.Dos.DataAccess
{
    public class AnswerService : Repository<Answer>
    {
        public AnswerService()
        {

        }

        public static List<Answer> GetList(int homeWorkId)
        {
            return Query(p => p.HomeWorkID == homeWorkId);
        }
    }
}
