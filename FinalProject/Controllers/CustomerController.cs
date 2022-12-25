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
    public class CustomerController : ApiController
    {
        //[RoutePrefix("api/customer")]
        [EnableCors("*", "*", "*")]
        public class CustomersController : ApiController
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
            [Route("api/category/{id}/customers")]
            [HttpGet]
            public HttpResponseMessage GetCtCustomer(string id)
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
                    return Request.CreateResponse(HttpStatusCode.OK, "customer updated successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error updating customer", e);
                }
            }

            [Route("api/category/delete/{id}")]
            [HttpDelete]
            public HttpResponseMessage Delete(string id)
            {
                try
                {
                    CustomerService.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.Created, "customer delete successfully");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "Error deleting customer", e);
                }
            }
        }
    }
}

