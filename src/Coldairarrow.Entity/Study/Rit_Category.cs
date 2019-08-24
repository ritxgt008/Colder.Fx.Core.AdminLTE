using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coldairarrow.Entity.Study
{
    /// <summary>
    /// 项目类别
    /// </summary>
    [Table("Rit_Category")]
    public class Rit_Category
    {

        /// <summary>
        /// Id
        /// </summary>
        [Key, Column(Order = 1)]
        public String Id { get; set; }

        /// <summary>
        /// 分类名称
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// 父级
        /// </summary>
        public String ParentID { get; set; }

        /// <summary>
        /// 层级。树状结构的层级
        /// </summary>
        public Int32? LevelID { get; set; }

        /// <summary>
        /// 排序。同级内排序
        /// </summary>
        public Int32? Sort { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
        public Boolean Enable { get; set; }

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