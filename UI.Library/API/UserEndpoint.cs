using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API
{
    public class UserEndpoint : IUserEndpoint
    {
        public IAPIHelper _apiHelper { get; }
        public UserEndpoint(IAPIHelper apiHelper)
        {
            _apiHelper = apiHelper;
        }

        public async Task CreateUser(CreateUserModel model)
        {
            var data = new
            {
                model.FirstName,
                model.LastName,
                model.EmailAddress,
                model.Password
            };

            using (HttpResponseMessage response = await _apiHelper.ApiClient.PostAsJsonAsync("/api/User/Register", data))
            {
                if (response.IsSuccessStatusCode == false)
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }

        public async Task<UserModel> GetAll()
        {
            using (HttpResponseMessage response = await _apiHelper.ApiClient.GetAsync("/api/User"))
            {
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<UserModel>();
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
