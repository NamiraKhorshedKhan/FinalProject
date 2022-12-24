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
    public class BookingService
    {
        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory.BookingDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<BookingDTO>>(data);
        }
        public static BookingDTO Get(string id)
        {
            var data = DataAccessFactory.BookingDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Booking, BookingDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<BookingDTO>(data);
        }
        public static BookingDTO Add(BookingDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingDTO, Booking>();
                cfg.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Booking>(obj);
            var rs = DataAccessFactory.BookingDataAccess().Add(converted);
            return mapper.Map<BookingDTO>(rs);
        }
        public static BookingDTO Update(BookingDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<BookingDTO, Booking>();
                cfg.CreateMap<Booking, BookingDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Booking>(obj);
            var update = DataAccessFactory.BookingDataAccess().Update(converted);
            return mapper.Map<BookingDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.BookingDataAccess().Delete(id);
        }
        public static BookingPaymentDTO GetwithPayments(string id)
        {
            var data = DataAccessFactory.BookingDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Booking, BookingPaymentDTO>();
                c.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<BookingPaymentDTO>(data);
        }
    }
}
