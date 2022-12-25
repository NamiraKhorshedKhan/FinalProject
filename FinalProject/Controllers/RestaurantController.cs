using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace FinalProject.Controllers
{
    
    public class RestaurantController: ApiController
    {
        [Route("api/Restaurants")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = RestaurantService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Restaurants/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(string id)
        {
            var data = RestaurantService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }


        [Route("api/Restaurants/add")]
        [HttpPost]
        public HttpResponseMessage Add(RestaurantDTO Restaurant)
        {
            if (ModelState.IsValid)
            {
                var data = RestaurantService.Add(Restaurant);
                if (data != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

        }

        [Route("api/Restaurants/Delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                RestaurantService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "Restaurant remove successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error removing Restaurant", e);
            }
        }

        [Route("api/Restaurants/Update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(RestaurantDTO cat)
        {
            try
            {
                RestaurantService.Update(cat);
                return Request.CreateResponse(HttpStatusCode.OK, "Restaurant updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating Restaurant", e);
            }
        }

    }
}