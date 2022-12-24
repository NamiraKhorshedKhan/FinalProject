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
    public class RestaurantService
    {
        public static List<RestaurantDTO> Get()
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<RestaurantDTO>>(data);
        }
        public static RestaurantDTO Get(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Restaurant, RestaurantDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantDTO>(data);
        }
        public static RestaurantDTO Add(RestaurantDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RestaurantDTO, Restaurant>();
                cfg.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Restaurant>(obj);
            var rs = DataAccessFactory.RestaurantDataAccess().Add(converted);
            return mapper.Map<RestaurantDTO>(rs);
        }
        public static RestaurantDTO Update(RestaurantDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RestaurantDTO, Restaurant>();
                cfg.CreateMap<Restaurant, RestaurantDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Restaurant>(obj);
            var update = DataAccessFactory.RestaurantDataAccess().Update(converted);
            return mapper.Map<RestaurantDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.RestaurantDataAccess().Delete(id);
        }
        public static RestaurantBookingDTO GetwithBookings(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantBookingDTO>();
                c.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantBookingDTO>(data);
        }
        public static RestaurantMenuDTO GetwithMenus(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantMenuDTO>();
                c.CreateMap<Menu, MenuDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantMenuDTO>(data);
        }
        public static RestaurantPaymentDTO GetwithPayments(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantPaymentDTO>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantPaymentDTO>(data);
        }
        public static RestaurantRatingDTO GetwithRatings(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantRatingDTO>();
                c.CreateMap<Rating, RatingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantRatingDTO>(data);
        }
        public static RestaurantReviewDTO GetwithReviews(string id)
        {
            var data = DataAccessFactory.RestaurantDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Restaurant, RestaurantReviewDTO>();
                c.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<RestaurantReviewDTO>(data);
        }
    }
}
