using UI.Library.Models;

namespace UI.Library.API
{
    public interface IUserEndpoint
    {
        IAPIHelper _apiHelper { get; }

        Task CreateUser(CreateUserModel model);
    }
}