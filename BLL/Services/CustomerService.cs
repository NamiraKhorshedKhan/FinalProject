using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EFs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CustomerService
    {
        public static List<CustomerDTO> Get()
        {
            var data = DataAccessFactory.CustomerDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<CustomerDTO>>(data);
        }
        public static CustomerDTO Get(string id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Customer, CustomerDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerDTO>(data);
        }
        public static CustomerDTO Add(CustomerDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Customer>(obj);
            var rs = DataAccessFactory.CustomerDataAccess().Add(converted);
            return mapper.Map<CustomerDTO>(rs);
        }
        public static CustomerDTO Update(CustomerDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<CustomerDTO, Customer>();
                cfg.CreateMap<Customer, CustomerDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Customer>(obj);
            var update = DataAccessFactory.CustomerDataAccess().Update(converted);
            return mapper.Map<CustomerDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.CustomerDataAccess().Delete(id);
        }
        public static CustomerBookingDTO GetwithBookings(string id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerBookingDTO>();
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerBookingDTO>(data);
        }
        public static CustomerPaymentDTO GetwithPayments(string id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerPaymentDTO>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerPaymentDTO>(data);
        }
        public static CustomerRatingDTO GetwithRatings(string id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerRatingDTO>();
                c.CreateMap<Rating, RatingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerRatingDTO>(data);
        }
        public static CustomerReviewDTO GetwithReviews(string id)
        {
            var data = DataAccessFactory.CustomerDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Customer, CustomerReviewDTO>();
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<CustomerReviewDTO>(data);
        }
    }
}
