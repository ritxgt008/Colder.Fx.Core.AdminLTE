using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Study
{
    /// <summary>
    /// 经费支出
    /// </summary>
    [Table("Rit_Outlay")]
    public class Rit_Outlay
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 项目ID号
        /// </summary>
        public String ProjectID { get; set; }

        /// <summary>
        /// 经费项目ID号
        /// </summary>
        public String FundID { get; set; }

        /// <summary>
        /// 支出名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 支出金额
        /// </summary>
        public Decimal OAmount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public String Remark { get; set; }

        /// <summary>
        /// 支出时间
        /// </summary>
        public DateTime? OTime { get; set; }

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