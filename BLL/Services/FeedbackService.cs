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
    public class FeedbackService
    {
        public static List<FeedbackDTO> Get()
        {
            var data = DataAccessFactory.FeedbackDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<FeedbackDTO>>(data);
        }
        public static FeedbackDTO Get(string id)
        {
            var data = DataAccessFactory.FeedbackDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Feedback, FeedbackDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<FeedbackDTO>(data);
        }
        public static FeedbackDTO Add(FeedbackDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<FeedbackDTO, Feedback>();
                cfg.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Feedback>(obj);
            var rs = DataAccessFactory.FeedbackDataAccess().Add(converted);
            return mapper.Map<FeedbackDTO>(rs);
        }
        public static FeedbackDTO Update(FeedbackDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<FeedbackDTO, Feedback>();
                cfg.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Feedback>(obj);
            var update = DataAccessFactory.FeedbackDataAccess().Update(converted);
            return mapper.Map<FeedbackDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.FeedbackDataAccess().Delete(id);
        }
    }
}
