using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Coldairarrow.Business.Study
{
    public class Rit_OutlayBusiness : BaseBusiness<Rit_Outlay>, IRit_OutlayBusiness, IDependency
    {
        #region 外部接口

        public List<Rit_Outlay> GetDataList(Pagination pagination, string condition, string keyword)
        {
            var q = GetIQueryable();
            //筛选
            if (!condition.IsNullOrEmpty() && !keyword.IsNullOrEmpty())
                q = q.Where($@"{condition}.Contains(@0)", keyword);

            return q.GetPagination(pagination).ToList();
        }

        public Rit_Outlay GetTheData(string id)
        {
            return GetEntity(id);
        }

        public AjaxResult AddData(Rit_Outlay newData)
        {
            Insert(newData);

            return Success();
        }

        public AjaxResult UpdateData(Rit_Outlay theData)
        {
            Update(theData);

            return Success();
        }

        public AjaxResult DeleteData(List<string> ids)
        {
            Delete(ids);

            return Success();
        }

        #endregion

        #region 私有成员

        #endregion

        #region 数据模型

        #endregion
    }
}