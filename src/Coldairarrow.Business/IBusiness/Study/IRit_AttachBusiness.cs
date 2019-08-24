using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_AttachBusiness
    {
        List<Rit_Attach> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Attach GetTheData(string id);
        AjaxResult AddData(Rit_Attach newData);
        AjaxResult UpdateData(Rit_Attach theData);
        AjaxResult DeleteData(List<string> ids);
    }
}