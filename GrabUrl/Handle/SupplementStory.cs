using Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabUrl.Handle
{
    public class SupplementStory
    {
        public void  SupplementUrl(List<StoryModel> list)
        {
            foreach (var item in list)
            {
                var path = "http://www.sodu.com/" + item.Name;
            }
        }


    }
}
