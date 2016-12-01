

namespace Common.Model
{
    /// <summary>
    /// 正则表达式
    /// </summary>
    public class RegExpModel
    {
        /// <summary>
        /// 编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 中文名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 英文名称
        /// </summary>
        public string UniueName { get; set; }
        /// <summary>
        /// 正则内容
        /// </summary>
        public string RegexContent { get; set; }
    }
}
