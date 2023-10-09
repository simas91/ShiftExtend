using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SEDataManager.Library.DataAccess;
using SEDataManager.Library.Models;
using System.Security.Claims;

namespace SEApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IUserData _userData;

        public ProfileController(IUserData userData)
        {
            _userData = userData;
        }

        [HttpGet]
        public UserModel GetById()
        {
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            return _userData.GetUserById(userId).First();
        }
    }
}
