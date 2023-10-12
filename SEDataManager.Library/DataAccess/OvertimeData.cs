using SEDataManager.Library.Internal;
using SEDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
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

        //public void AddOvertime(OvertimeModel model)
        //{
        //    _sql.SaveData("dbo.spOvertimes_Test", new { model.OvertimeDate, model.StartTime, model.EndTime, model.OP, model.CB, model.RT, model.Pack }, "SEData");
        //}

        public void AddOvertime(OvertimeModel model)
        {
            _sql.SaveData("dbo.spOvertimes_Test", new {model.OvertimeDate, model.StartTime, model.OP}, "SEData");
        }
    }
}
