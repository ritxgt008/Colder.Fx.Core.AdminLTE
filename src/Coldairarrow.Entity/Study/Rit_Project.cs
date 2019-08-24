using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Study
{
    /// <summary>
    /// 科研项目
    /// </summary>
    [Table("Rit_Project")]
    public class Rit_Project
    {

        /// <summary>
        /// 编号
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 项目类别ID
        /// </summary>
        public String CategoryID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 项目负责人
        /// </summary>
        public String Principal { get; set; }

        /// <summary>
        /// 申报单位
        /// </summary>
        public String Units { get; set; }

        /// <summary>
        /// 申报时间
        /// </summary>
        public DateTime? OnTime { get; set; }

        /// <summary>
        /// 立项时间
        /// </summary>
        public DateTime? ProjectTime { get; set; }

        /// <summary>
        /// 项目金额
        /// </summary>
        public Decimal ItemAmount { get; set; }

        /// <summary>
        /// 项目状态（0-未申请，1-申请状态，3-不通过，5-通过）
        /// </summary>
        public Byte? IsPass { get; set; }

        /// <summary>
        /// 项目所属用户姓名
        /// </summary>
        public String PName { get; set; }

        /// <summary>
        /// 项目所属用户ID号
        /// </summary>
        public String PUserID { get; set; }

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