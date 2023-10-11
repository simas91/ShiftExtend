using SEDataManager.Library.Models;

namespace SEDataManager.Library.DataAccess
{
    public interface IOvertimeData
    {
        void AddOvertime(OvertimeModel model);
        List<OvertimeModel> GetAllOvertimes();
    }
}