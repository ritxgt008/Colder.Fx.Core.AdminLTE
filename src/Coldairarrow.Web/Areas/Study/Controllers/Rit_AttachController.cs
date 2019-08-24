using Coldairarrow.Business.Study;
using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using Microsoft.AspNetCore.Mvc;

namespace Coldairarrow.Web.Areas.Study.Controllers
{
    [Area("Study")]
    public class Rit_AttachController : BaseMvcController
    {
        #region DI

        public Rit_AttachController(IRit_AttachBusiness rit_AttachBus)
        {
            _rit_AttachBus = rit_AttachBus;
        }
        IRit_AttachBusiness _rit_AttachBus { get; }

        #endregion

        #region 视图功能

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Form(string id)
        {
            var theData = id.IsNullOrEmpty() ? new Rit_Attach() : _rit_AttachBus.GetTheData(id);

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
            var dataList = _rit_AttachBus.GetDataList(pagination, condition, keyword);

            return DataTable_Bootstrap(dataList, pagination);
        }

        #endregion

        #region 提交数据

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="theData">保存的数据</param>
        public ActionResult SaveData(Rit_Attach theData)
        {
            AjaxResult res;
            if (theData.Id.IsNullOrEmpty())
            {
                theData.Id = IdHelper.GetId();

                res = _rit_AttachBus.AddData(theData);
            }
            else
            {
                res = _rit_AttachBus.UpdateData(theData);
            }

            return JsonContent(res.ToJson());
        }

        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="theData">删除的数据</param>
        public ActionResult DeleteData(string ids)
        {
            var res = _rit_AttachBus.DeleteData(ids.ToList<string>());

            return JsonContent(res.ToJson());
        }

        #endregion
    }
}