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
    //[RoutePrefix("api/admin")]
    [EnableCors("*", "*", "*")]
    public class AdminsController : ApiController
    {
        [Route("api/admin/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AdminService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/admin/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = AdminService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/admin/add")]
        [HttpPost]
        public HttpResponseMessage Add(AdminDTO ct)
        {
            try
            {
                var data = AdminService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/admin/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(AdminDTO ct)
        {
            try
            {
                AdminService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "admin updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating admin", e);
            }
        }

        [Route("api/admin/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                AdminService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "admin delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting admin", e);
            }
        }
    }
}