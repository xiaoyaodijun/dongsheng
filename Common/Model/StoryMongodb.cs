using MongoDB.Bson;

namespace Common.Model
{
    public class StoryMongodb
    {
        /// <summary>
        /// 编号
        /// </summary>
        public ObjectId Id { get; set; }

        /// <summary>
        /// 书的编号
        /// </summary>
        public int StoryId { get; set; }

        /// <summary>
        /// 书的名字
        /// </summary>
        public string StoryName { get; set; }

        /// <summary>
        /// 章节名称
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 章节内容
        /// </summary>
        public string Content { get; set; }

    }
}
