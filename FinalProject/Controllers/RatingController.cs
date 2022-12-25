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



    //[RoutePrefix("api/rating")]
    [EnableCors("*", "*", "*")]
    public class RatingsController : ApiController
    {
        [Route("api/rating/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = RatingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/rating/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = RatingService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/rating/add")]
        [HttpPost]
        public HttpResponseMessage Add(RatingDTO ct)
        {
            try
            {
                var data = RatingService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }



        }



        [Route("api/rating/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(RatingDTO ct)
        {
            try
            {
                RatingService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "rating updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating rating", e);
            }
        }



        [Route("api/rating/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                RatingService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "rating delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting rating", e);
            }
        }
    }
}