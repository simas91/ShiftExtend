﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using UI.Library.Models;

namespace UI.Library.API
{
    public class APIHelper : IAPIHelper
    {
        // One HttpClient for the entire duration of the app
        private HttpClient _apiClient;
        private readonly ILoggedInUserModel _loggedInUser;
        private readonly IConfiguration _config;

        public APIHelper(ILoggedInUserModel loggedInUser, IConfiguration config)
        {
            // !WARNING INITIALIZE CLIENT AT THE END
            _loggedInUser = loggedInUser;
            _config = config;
            InitializeClient();
        }

        private void InitializeClient()
        {
            string api = _config.GetValue<string>("api");

            _apiClient = new();
            _apiClient.BaseAddress = new Uri(api);
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public HttpClient ApiClient
        {
            get
            {
                return _apiClient;
            }
        }

        public async Task<AuthenticatedUser> Authenticate(string username, string password)
        {
            var data = new FormUrlEncodedContent(new[]
            {
                new KeyValuePair<string, string>("grant_type", "password"),
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });

            // passing only relative path, not full url
            using HttpResponseMessage response = await _apiClient.PostAsync("/Token", data);
            if (response.IsSuccessStatusCode)
            {
                // nuget package for ReadAsAsync microsoft.aspnet.webapi.client
                var result = await response.Content.ReadAsAsync<AuthenticatedUser>();
                return result;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }


        // Does not return LoggedInUserModel
        // saves in class, which everyone has access to
        public async Task GetLoggedInUserInfo(string token)
        {
            // HttpClient, adds a header, same as with swagger testing on web api
            // Double clear to be sure its clean
            _apiClient.DefaultRequestHeaders.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Clear();
            _apiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _apiClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

            using HttpResponseMessage response = await _apiClient.GetAsync("/api/User");
            if (response.IsSuccessStatusCode)
            {
                // gets LoggedInUserModel, once its updated here it is updated everywhere because Singleton
                var result = await response.Content.ReadAsAsync<LoggedInUserModel>();
                _loggedInUser.CreatedDate = result.CreatedDate;
                _loggedInUser.EmailAddress = result.EmailAddress;
                _loggedInUser.FirstName = result.FirstName;
                _loggedInUser.Id = result.Id;
                _loggedInUser.LastName = result.LastName;
                _loggedInUser.Token = token;
            }
            else
            {
                throw new Exception(response.ReasonPhrase);
            }
        }

        public void LogOffUser()
        {
            // clearing token from api
            _apiClient.DefaultRequestHeaders.Clear();
        }
    }
}
