using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_FundBusiness
    {
        List<Rit_Fund> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Fund GetTheData(string id);
        AjaxResult AddData(Rit_Fund newData);
        AjaxResult UpdateData(Rit_Fund theData);
        AjaxResult DeleteData(List<string> ids);
    }
}