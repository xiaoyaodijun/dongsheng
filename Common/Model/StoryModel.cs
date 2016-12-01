

namespace Common.Model
{
    public class StoryModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 0标识更新，1标识断更，2标识完结
        /// </summary>
        public int Flag { get; set; }
    }
}
