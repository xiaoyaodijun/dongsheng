using GrabUrl.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabUrl.Handle
{
    public class AnalyseUrl
    {
        public void GetUrl()
        {
            //获取url为空的路径
            var list = OperationMysql.GetStoryByGetUrlEmpty();
            if (list.Count > 0)
            {
               
                
            }


        }

    }
}
