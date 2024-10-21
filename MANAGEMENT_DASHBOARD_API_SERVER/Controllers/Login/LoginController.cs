using MANAGEMENT_DASHBOARD_API_SERVER.Models.Login;
using MANAGEMENT_DASHBOARD_API_SERVER.Repositories.Login;
using MANAGEMENT_DASHBOARD_API_SERVER.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using AllowAnonymousAttribute = System.Web.Http.AllowAnonymousAttribute;

namespace MANAGEMENT_DASHBOARD_API_SERVER.Controllers.Login
{
    public class LoginController : ApiController
    {
        private readonly AuthService _authService;

        public LoginController()
        {
            var loginRepository = new LoginRepository();
            _authService = new AuthService(loginRepository);
        }

        [AllowAnonymous]
        // GET: Login
        public IHttpActionResult Get()
        {
            return Ok("API PASSED!");
        }

        [AllowAnonymous]
        // POST: Login
        public IHttpActionResult Post(LoginRequest loginRequest)
        {
            var loginResult = _authService.Authenticate(loginRequest.USERNAME, loginRequest.PASSWORD);
            if (loginResult.ACCESS_TOKEN == null)
                return Unauthorized();

            return Ok(loginResult);
        }

    }
}