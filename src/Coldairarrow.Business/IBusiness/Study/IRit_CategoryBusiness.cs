using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_CategoryBusiness
    {
        List<Rit_Category> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Category GetTheData(string id);
        AjaxResult AddData(Rit_Category newData);
        AjaxResult UpdateData(Rit_Category theData);
        AjaxResult DeleteData(List<string> ids);
    }
}