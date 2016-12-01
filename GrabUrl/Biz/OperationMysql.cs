using System;
using System.Collections.Generic;
using Common.Model;
using Common.Help;


namespace GrabUrl.Biz
{
    public class OperationMysql
    {
        //获取路劲为空的小说
        public static List<StoryModel> GetStoryByGetUrlEmpty()
        {
            var sql = "select * from gs_stroy where getUrl=''";
            return TQueryList.ToList<StoryModel>(sql);
        }

    }
}
