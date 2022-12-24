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
    public class MenuService
    {
        public static List<MenuDTO> Get()
        {
            var data = DataAccessFactory.MenuDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Menu, MenuDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<MenuDTO>>(data);
        }
        public static MenuDTO Get(string id)
        {
            var data = DataAccessFactory.MenuDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Menu, MenuDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<MenuDTO>(data);
        }
        public static MenuDTO Add(MenuDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MenuDTO, Menu>();
                cfg.CreateMap<Menu, MenuDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Menu>(obj);
            var rs = DataAccessFactory.MenuDataAccess().Add(converted);
            return mapper.Map<MenuDTO>(rs);
        }
        public static MenuDTO Update(MenuDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<MenuDTO, Menu>();
                cfg.CreateMap<Menu, MenuDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Menu>(obj);
            var update = DataAccessFactory.MenuDataAccess().Update(converted);
            return mapper.Map<MenuDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.MenuDataAccess().Delete(id);
        }
    }
}
