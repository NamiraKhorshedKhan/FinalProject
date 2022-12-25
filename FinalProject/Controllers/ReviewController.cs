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



    //[RoutePrefix("api/review")]
    [EnableCors("*", "*", "*")]
    public class ReviewsController : ApiController
    {
        [Route("api/review/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ReviewService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/review/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = ReviewService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/review/add")]
        [HttpPost]
        public HttpResponseMessage Add(ReviewDTO ct)
        {
            try
            {
                var data = ReviewService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }



        }



        [Route("api/review/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(ReviewDTO ct)
        {
            try
            {
                ReviewService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "review updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating review", e);
            }
        }



        [Route("api/review/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                ReviewService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "review delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting review", e);
            }
        }
    }
}