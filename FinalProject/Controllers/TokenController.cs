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



    //[RoutePrefix("api/token")]
    [EnableCors("*", "*", "*")]
    public class TokensController : ApiController
    {
        [Route("api/token/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = TokenService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/token/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = TokenService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/token/add")]
        [HttpPost]
        public HttpResponseMessage Add(TokenDTO ct)
        {
            try
            {
                var data = TokenService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }



        }



        [Route("api/token/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(TokenDTO ct)
        {
            try
            {
                TokenService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "token updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating token", e);
            }
        }



        [Route("api/token/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                TokenService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "token delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting token", e);
            }
        }
    }
}