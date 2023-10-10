using SEDataManager.Library.Models;

namespace SEDataManager.Library.DataAccess
{
    public interface IOvertimeData
    {
        List<OvertimeModel> GetAllOvertimes();
    }
}