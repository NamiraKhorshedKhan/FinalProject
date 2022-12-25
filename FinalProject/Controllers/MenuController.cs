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
    [EnableCors("*", "*", "*")]
    public class MenuController : ApiController
    {
        [Route("api/menu/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = MenuService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/menu/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = MenuService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/menu/add")]
        [HttpPost]
        public HttpResponseMessage Add(MenuDTO ct)
        {
            try
            {
                var data = MenuService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/menu/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(MenuDTO ct)
        {
            try
            {
                MenuService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "Menu updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating menu", e);
            }
        }

        [Route("api/menu/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                MenuService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "Menu deleted successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting menu", e);
            }
        }
    }
}