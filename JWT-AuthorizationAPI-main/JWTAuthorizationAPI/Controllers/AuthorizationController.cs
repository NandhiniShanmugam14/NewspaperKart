using JWTAuthorizationAPI.CTSModel;
using JWTAuthorizationAPI.Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTAuthorizationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(AuthorizationController));

        private IConfiguration config;
        private readonly IVendorAuthProvider<Vendortbl> ven_ap;
        private readonly ICustomerAuthProvider<Customertbl> cus_ap;
        private readonly IAdminAuthProvider<Admintbl> ad_ap;

        public AuthorizationController(IConfiguration config, IVendorAuthProvider<Vendortbl> ven_ap, ICustomerAuthProvider<Customertbl> cus_ap, IAdminAuthProvider<Admintbl> ad_ap)
        {
            this.config = config;
            this.ven_ap = ven_ap;
            this.cus_ap = cus_ap;
            this.ad_ap = ad_ap;
        }

        [HttpPost]
        [Route("Customer")]
        public IActionResult Login([FromBody] Customertbl login)
        {
            _log4net.Info("Http Post request");
            if (login == null)
            {
                return BadRequest();
            }
            try
            {

                IActionResult response = Unauthorized();
                Customertbl user = cus_ap.AuthenticateUser(login);

                if (user != null)
                {
                    var tokenString = cus_ap.GenerateJSONWebToken(user, config);
                    response = Ok(tokenString);

                }

                return response;
            }
            catch (Exception e)
            {
                _log4net.Error("Exception Occured " + e.Message);
                return StatusCode(500);
            }

        }
        [HttpPost]
        [Route("Vendor")]
        public IActionResult Login([FromBody] Vendortbl login)
        {
            _log4net.Info(" Http Post request");
            if (login == null)
            {
                return BadRequest();
            }
            try
            {

                IActionResult response = Unauthorized();
                Vendortbl user = ven_ap.AuthenticateUser(login);

                if (user != null)
                {
                    var tokenString = ven_ap.GenerateJSONWebToken(user, config);
                    response = Ok(tokenString);

                }

                return response;
            }

            catch (Exception e)
            {
                _log4net.Error("Exception Occured " + e.Message);
                return StatusCode(500);
            }

        }
        [HttpPost]
        [Route("Admin")]
        public IActionResult Login([FromBody] Admintbl login)
        {
            _log4net.Info("Http Post request");
            if (login == null)
            {
                return BadRequest();
            }
            try
            {

                IActionResult response = Unauthorized();
                Admintbl user = ad_ap.AuthenticateUser(login);

                if (user != null)
                {
                    var tokenString = ad_ap.GenerateJSONWebToken(user, config);
                    response = Ok(tokenString);

                }

                return response;
            }
            catch (Exception e)
            {
                _log4net.Error("Exception Occured " + e.Message);
                return StatusCode(500);
            }

        }
        [HttpGet("CheckAuthentication")]
        [Authorize]
        //[AllowAnonymous]
        public IActionResult CheckAuthentication()
        {
            return Ok(true);
        }
    }
}
