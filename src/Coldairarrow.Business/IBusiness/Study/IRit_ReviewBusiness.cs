using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_ReviewBusiness
    {
        List<Rit_Review> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Review GetTheData(string id);
        AjaxResult AddData(Rit_Review newData);
        AjaxResult UpdateData(Rit_Review theData);
        AjaxResult DeleteData(List<string> ids);
    }
}