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
    public class RatingService
    {
        public static List<RatingDTO> Get()
        {
            var data = DataAccessFactory.RatingDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Rating, RatingDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<RatingDTO>>(data);
        }
        public static RatingDTO Get(string id)
        {
            var data = DataAccessFactory.RatingDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Rating, RatingDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<RatingDTO>(data);
        }
        public static RatingDTO Add(RatingDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RatingDTO, Rating>();
                cfg.CreateMap<Rating, RatingDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Rating>(obj);
            var rs = DataAccessFactory.RatingDataAccess().Add(converted);
            return mapper.Map<RatingDTO>(rs);
        }
        public static RatingDTO Update(RatingDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<RatingDTO, Rating>();
                cfg.CreateMap<Rating, RatingDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Rating>(obj);
            var update = DataAccessFactory.RatingDataAccess().Update(converted);
            return mapper.Map<RatingDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.RatingDataAccess().Delete(id);
        }
    }
}
