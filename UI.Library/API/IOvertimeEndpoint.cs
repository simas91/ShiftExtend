using UI.Library.Models;

namespace UI.Library.API
{
    public interface IOvertimeEndpoint
    {
        Task<List<OvertimeModel>> GetAll();
    }
}