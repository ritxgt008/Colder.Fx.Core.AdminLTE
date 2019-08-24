using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Study
{
    /// <summary>
    /// 附件列表
    /// </summary>
    [Table("Rit_Attach")]
    public class Rit_Attach
    {

        /// <summary>
        /// 自增ID
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 所属表ID
        /// </summary>
        public String TID { get; set; }

        /// <summary>
        /// 所属表名称
        /// </summary>
        public String TName { get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        public String Filename { get; set; }

        /// <summary>
        /// 文件路径
        /// </summary>
        public String Filepath { get; set; }

        /// <summary>
        /// 文件大小(字节)
        /// </summary>
        public Int32? Filesize { get; set; }

        /// <summary>
        /// 文件扩展名
        /// </summary>
        public String Fileext { get; set; }

        /// <summary>
        /// 下载次数
        /// </summary>
        public Int32? Downnum { get; set; }

        /// <summary>
        /// 上传时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// UpdateTime
        /// </summary>
        public DateTime? UpdateTime { get; set; }

    }
}