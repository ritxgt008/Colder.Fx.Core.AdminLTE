using Coldairarrow.Entity.Study;
using Coldairarrow.Util;
using System.Collections.Generic;

namespace Coldairarrow.Business.Study
{
    public interface IRit_ProjectBusiness
    {
        List<Rit_Project> GetDataList(Pagination pagination, string condition, string keyword);
        Rit_Project GetTheData(string id);
        AjaxResult AddData(Rit_Project newData);
        AjaxResult UpdateData(Rit_Project theData);
        AjaxResult DeleteData(List<string> ids);
    }
}