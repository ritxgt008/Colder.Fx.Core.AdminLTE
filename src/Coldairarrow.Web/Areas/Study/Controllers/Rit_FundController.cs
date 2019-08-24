using Coldairarrow.Business.Study;
using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;

namespace Coldairarrow.Web.Areas.Study.Controllers
{
    [Area("Study")]
    public class Rit_FundController : BaseMvcController
    {
        #region DI

        public Rit_FundController(IRit_FundBusiness rit_FundBus)
        {
            _rit_FundBus = rit_FundBus;
        }
        IRit_FundBusiness _rit_FundBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Rit_Fund() : _rit_FundBus.GetTheData(id);

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
            var dataList = _rit_FundBus.GetDataList(pagination, condition, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Rit_Fund theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _rit_FundBus.AddData(theData);
            }
            else
            {
                res = _rit_FundBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _rit_FundBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}