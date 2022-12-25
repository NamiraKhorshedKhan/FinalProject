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
    public class PaymentController : ApiController
    {
        [Route("api/payment/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PaymentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/payment/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = PaymentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/payment/add")]
        [HttpPost]
        public HttpResponseMessage Add(PaymentDTO ct)
        {
            try
            {
                var data = PaymentService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/payment/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(PaymentDTO ct)
        {
            try
            {
                PaymentService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "Payment updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating payment", e);
            }
        }

        [Route("api/payment/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                PaymentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "Payment deleted successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting payment", e);
            }
        }
    }
}
