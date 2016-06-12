using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zxxk.Dos.DataAccess;

namespace Zxxk.Dos.Business
{
    public class HomeWorkLayer : IHomeWrokLayer
    {
        public string GetUserHomeWrok()
        {
            AnswerService.GetList(1);
            return "";
        }
    }
}
