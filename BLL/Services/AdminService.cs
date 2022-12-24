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
    public class AdminService
    {
        public static List<AdminDTO> Get()
        {
            var data = DataAccessFactory.AdminDataAccess().Get();
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            return mapper.Map<List<AdminDTO>>(data);
        }
        public static AdminDTO Get(string id)
        {
            var data = DataAccessFactory.AdminDataAccess().Get(id);
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Admin, AdminDTO>();

            });
            var mapper = new Mapper(config);
            return mapper.Map<AdminDTO>(data);
        }
        public static AdminDTO Add(AdminDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Admin>(obj);
            var rs = DataAccessFactory.AdminDataAccess().Add(converted);
            return mapper.Map<AdminDTO>(rs);
        }
        public static AdminDTO Update(AdminDTO obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });
            var mapper = new Mapper(config);
            var converted = mapper.Map<Admin>(obj);
            var update = DataAccessFactory.AdminDataAccess().Update(converted);
            return mapper.Map<AdminDTO>(update);
        }
        public static bool Delete(string id)
        {
            return DataAccessFactory.AdminDataAccess().Delete(id);
        }
    }
}
