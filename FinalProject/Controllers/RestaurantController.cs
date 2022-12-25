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
    public class RestaurantController : ApiController
    {
        [Route("api/restaurant/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RestaurantService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/restaurant/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = RestaurantService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/add")]
        [HttpPost]
        public HttpResponseMessage Add(RestaurantDTO ct)
        {
            try
            {
                var data = RestaurantService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(RestaurantDTO ct)
        {
            try
            {
                RestaurantService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "Restaurant updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating restaurant", e);
            }
        }

        [Route("api/restaurant/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                RestaurantService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "Restaurant deleted successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting restaurant", e);
            }
        }

        [Route("api/restaurant/{id}/menu")]
        [HttpGet]
        public HttpResponseMessage GetMenus(string id)
        {
            try
            {
                var data = RestaurantService.GetwithMenus(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/{id}/booking")]
        [HttpGet]
        public HttpResponseMessage GetBookings(string id)
        {
            try
            {
                var data = RestaurantService.GetwithBookings(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/{id}/payment")]
        [HttpGet]
        public HttpResponseMessage GetPayments(string id)
        {
            try
            {
                var data = RestaurantService.GetwithPayments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/{id}/review")]
        [HttpGet]
        public HttpResponseMessage GetReviews(string id)
        {
            try
            {
                var data = RestaurantService.GetwithReviews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/restaurant/{id}/rating")]
        [HttpGet]
        public HttpResponseMessage GetRatings(string id)
        {
            try
            {
                var data = RestaurantService.GetwithRatings(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}