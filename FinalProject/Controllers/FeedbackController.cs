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

    //[RoutePrefix("api/feedback")]
    [EnableCors("*", "*", "*")]
    public class FeedbacksController : ApiController
    {
        [Route("api/feedback/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = FeedbackService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/feedback/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = FeedbackService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/feedback/add")]
        [HttpPost]
        public HttpResponseMessage Add(FeedbackDTO ct)
        {
            try
            {
                var data = FeedbackService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/feedback/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(FeedbackDTO ct)
        {
            try
            {
                FeedbackService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "feedback updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating feedback", e);
            }
        }

        [Route("api/feedback/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                FeedbackService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "feedback delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting feedback", e);
            }
        }
    }
}