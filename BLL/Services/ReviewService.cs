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
    public class ReviewService
    {
        public static List<ReviewDTO> Get()
        {
            var data = DataAccessFactory.ReviewDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<ReviewDTO>>(data);
        }
        public static ReviewDTO Get(string id)
        {
            var data = DataAccessFactory.ReviewDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Review, ReviewDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<ReviewDTO>(data);
        }
        public static ReviewDTO Add(ReviewDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ReviewDTO, Review>();
                cfg.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Review>(obj);
            var rs = DataAccessFactory.ReviewDataAccess().Add(converted);
            return mapper.Map<ReviewDTO>(rs);
        }
        public static ReviewDTO Update(ReviewDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ReviewDTO, Review>();
                cfg.CreateMap<Review, ReviewDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Review>(obj);
            var update = DataAccessFactory.ReviewDataAccess().Update(converted);
            return mapper.Map<ReviewDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.ReviewDataAccess().Delete(id);
        }
    }
}
