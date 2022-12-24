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
    public class TokenService
    {
        public static List<TokenDTO> Get()
        {
            var data = DataAccessFactory.TokenDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<TokenDTO>>(data);
        }
        public static TokenDTO Get(string id)
        {
            var data = DataAccessFactory.TokenDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Token, TokenDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<TokenDTO>(data);
        }
        public static TokenDTO Add(TokenDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TokenDTO, Token>();
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Token>(obj);
            var rs = DataAccessFactory.TokenDataAccess().Add(converted);
            return mapper.Map<TokenDTO>(rs);
        }
        public static TokenDTO Update(TokenDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<TokenDTO, Token>();
                cfg.CreateMap<Token, TokenDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Token>(obj);
            var update = DataAccessFactory.TokenDataAccess().Update(converted);
            return mapper.Map<TokenDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.TokenDataAccess().Delete(id);
        }
    }
}
