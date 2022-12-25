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
    public class CustomerController : ApiController
    {
        [Route("api/customer/all")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = CustomerService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [Route("api/customer/{id}")]
        public HttpResponseMessage Get(string id)
        {
            try
            {
                var data = CustomerService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/add")]
        [HttpPost]
        public HttpResponseMessage Add(CustomerDTO ct)
        {
            try
            {
                var data = CustomerService.Add(ct);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/update/{id}")]
        [HttpPut]
        public HttpResponseMessage Put(CustomerDTO ct)
        {
            try
            {
                CustomerService.Update(ct);
                return Request.CreateResponse(HttpStatusCode.OK, "Customer updated successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating customer", e);
            }
        }

        [Route("api/customer/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(string id)
        {
            try
            {
                CustomerService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.Created, "Customer delete successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting customer", e);
            }
        }

        [Route("api/customer/{id}/booking")]
        [HttpGet]
        public HttpResponseMessage GetBookings(string id)
        {
            try
            {
                var data = CustomerService.GetwithBookings(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/{id}/payment")]
        [HttpGet]
        public HttpResponseMessage GetPayments(string id)
        {
            try
            {
                var data = CustomerService.GetwithPayments(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/{id}/review")]
        [HttpGet]
        public HttpResponseMessage GetReviews(string id)
        {
            try
            {
                var data = CustomerService.GetwithReviews(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [Route("api/customer/{id}/rating")]
        [HttpGet]
        public HttpResponseMessage GetRatings(string id)
        {
            try
            {
                var data = CustomerService.GetwithRatings(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}