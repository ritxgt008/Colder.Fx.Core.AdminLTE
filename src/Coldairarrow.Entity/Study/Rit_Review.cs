using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Study
{
    /// <summary>
    /// 项目评审
    /// </summary>
    [Table("Rit_Review")]
    public class Rit_Review
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 审核级别
        /// </summary>
        public Byte? RType { get; set; }

        /// <summary>
        /// 项目ID号
        /// </summary>
        public String ProjectID { get; set; }

        /// <summary>
        /// 审核意见
        /// </summary>
        public String ROpinion { get; set; }

        /// <summary>
        /// 评分
        /// </summary>
        public Decimal RScore { get; set; }

        /// <summary>
        /// 审核状态（1-通过，3-未通过）
        /// </summary>
        public Byte? RPass { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime? RTime { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public String RName { get; set; }

        /// <summary>
        /// 审核人ID号
        /// </summary>
        public String RUserID { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public String CreateUser { get; set; }

        /// <summary>
        /// 创建用户
        /// </summary>
        public String CreateUserID { get; set; }

        /// <summary>
        /// 创建地址
        /// </summary>
        public String CreateIP { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 更新用户
        /// </summary>
        public String UpdateUser { get; set; }

        /// <summary>
        /// 更新用户
        /// </summary>
        public String UpdateUserID { get; set; }

        /// <summary>
        /// 更新地址
        /// </summary>
        public String UpdateIP { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTime? UpdateTime { get; set; }

    }
}