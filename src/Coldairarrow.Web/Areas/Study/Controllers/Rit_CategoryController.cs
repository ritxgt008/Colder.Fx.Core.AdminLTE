using Coldairarrow.Business.Study;
using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Coldairarrow.Web.Areas.Study.Controllers
{
    [Area("Study")]
    public class Rit_CategoryController : BaseMvcController
    {
        #region DI

        public Rit_CategoryController(IRit_CategoryBusiness rit_CategoryBus)
        {
            _rit_CategoryBus = rit_CategoryBus;
        }
        IRit_CategoryBusiness _rit_CategoryBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Rit_Category() : _rit_CategoryBus.GetTheData(id);

            return View(theData);
        }

        #endregion

        #region 获取数据

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="condition">查询类型</param>
        /// <param name="keyword">关键字</param>
        /// <returns></returns>
        public ActionResult GetDataList(Pagination pagination, string condition, string keyword)
        {
            var dataList = _rit_CategoryBus.GetDataList(pagination, condition, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

		public ActionResult GetDataList_ZTree()
		{
			var dataList = _rit_CategoryBus.GetDataList(new Pagination(), "", "");
			var resList = dataList.Select(x => new
			{
				id = x.Id,
				name = x.Name,
				pId = x.ParentID,
				open = true
			});

			return JsonContent(resList.ToJson());
		}
		#endregion

		#region 提交数据

		/// <summary>
		/// 保存
		/// </summary>
		/// <param name="theData">保存的数据</param>
		public ActionResult SaveData(Rit_Category theData)
        {
            AjaxResult res;
			DateTime de = DateTime.Now;
			theData.UpdateTime = de;

			Business.Operator ss = new Business.Operator();
			theData.UpdateUserID = ss.UserId;
			//获取客户端IP地址
			var remoteIpAddress = GetUserIp();
			theData.UpdateIP = remoteIpAddress.ToString();

			if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();
				theData.CreateTime = de;
				theData.CreateUserID = ss.UserId;
				theData.CreateIP = remoteIpAddress.ToString();
				res = _rit_CategoryBus.AddData(theData);
            }
            else
            {
				res = _rit_CategoryBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _rit_CategoryBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}