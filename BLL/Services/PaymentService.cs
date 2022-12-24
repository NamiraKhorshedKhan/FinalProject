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
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory.PaymentDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<PaymentDTO>>(data);
        }
        public static PaymentDTO Get(string id)
        {
            var data = DataAccessFactory.PaymentDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Payment, PaymentDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<PaymentDTO>(data);
        }
        public static PaymentDTO Add(PaymentDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PaymentDTO, Payment>();
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Payment>(obj);
            var rs = DataAccessFactory.PaymentDataAccess().Add(converted);
            return mapper.Map<PaymentDTO>(rs);
        }
        public static PaymentDTO Update(PaymentDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<PaymentDTO, Payment>();
                cfg.CreateMap<Payment, PaymentDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Payment>(obj);
            var update = DataAccessFactory.PaymentDataAccess().Update(converted);
            return mapper.Map<PaymentDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.PaymentDataAccess().Delete(id);
        }
    }
}
