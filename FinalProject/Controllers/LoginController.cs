using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace FinalProject.Controllers
{
    //[RoutePrefix("api/login")]
    [EnableCors("*", "*", "*")]
    public class LoginsController : ApiController
    {
        [Route("api/login/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = LoginService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/login/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = LoginService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/login/{id}/logins")]
        [HttpGet]
        public HttpResponseMessage GetCtLogin(string id)
        {
            try
            {
                var data = LoginService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/login/add")]
        [HttpPost]
        public HttpResponseMessage Add(LoginDTO ct)
        {
            try
            {
                var data = LoginService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/login/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(LoginDTO ct)
        {
            try
            {
                LoginService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "login updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating login", e);
            }
        }

        [Route("api/login/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                LoginService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "login delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting login", e);
            }
        }

    }
}