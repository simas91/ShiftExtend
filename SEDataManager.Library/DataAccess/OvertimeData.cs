using SEDataManager.Library.Internal;
using SEDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDataManager.Library.DataAccess
{
    public class OvertimeData : IOvertimeData
    {
        private readonly ISqlDataAccess _sql;

        public OvertimeData(ISqlDataAccess sql)
        {
            _sql = sql;
        }

        public List<OvertimeModel> GetAllOvertimes()
        {
            var output = _sql.LoadData<OvertimeModel, dynamic>("dbo.spOvertimes_GetAll", new { }, "SEData");
            return output;
        }
    }
}
