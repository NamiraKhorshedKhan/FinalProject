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
    public class LoginService
    {
        public static List<LoginDTO> Get()
        {
            var data = DataAccessFactory.LoginDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Login, LoginDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<LoginDTO>>(data);
        }
        public static LoginDTO Get(string id)
        {
            var data = DataAccessFactory.LoginDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Login, LoginDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<LoginDTO>(data);
        }
        public static LoginDTO Add(LoginDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LoginDTO, Login>();
                cfg.CreateMap<Login, LoginDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Login>(obj);
            var rs = DataAccessFactory.LoginDataAccess().Add(converted);
            return mapper.Map<LoginDTO>(rs);
        }
        public static LoginDTO Update(LoginDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<LoginDTO, Login>();
                cfg.CreateMap<Login, LoginDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Login>(obj);
            var update = DataAccessFactory.LoginDataAccess().Update(converted);
            return mapper.Map<LoginDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.LoginDataAccess().Delete(id);
        }
        public static LoginTokenDTO GetwithTokens(string id)
        {
            var data = DataAccessFactory.LoginDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Login, LoginTokenDTO>();
                c.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<LoginTokenDTO>(data);
        }
        public static LoginFeedbackDTO GetwithFeedbacks(string id)
        {
            var data = DataAccessFactory.LoginDataAccess().Get(id);
            var config = new MapperConfiguration(c => {
                c.CreateMap<Login, LoginFeedbackDTO>();
                c.CreateMap<Feedback, FeedbackDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<LoginFeedbackDTO>(data);
        }
    }
}
