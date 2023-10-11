using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDataManager.Library.DataAccess;
using SEDataManager.Library.Models;

namespace SEApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OvertimesController : ControllerBase
    {
        private readonly IOvertimeData _overtime;

        public OvertimesController(IOvertimeData overtime)
        {
            _overtime = overtime;
        }

        [HttpGet]
        public List<OvertimeModel> Get()
        {
            return _overtime.GetAllOvertimes();
        }

        [HttpPost]
        public void Post(OvertimeModel model)
        {
            _overtime.AddOvertime(model);
        }
    }
}
