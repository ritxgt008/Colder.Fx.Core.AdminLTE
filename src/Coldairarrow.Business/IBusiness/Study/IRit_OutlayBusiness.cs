using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_OutlayBusiness
    {
        List<Rit_Outlay> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Outlay GetTheData(string id);
        AjaxResult AddData(Rit_Outlay newData);
        AjaxResult UpdateData(Rit_Outlay theData);
        AjaxResult DeleteData(List<string> ids);
    }
}