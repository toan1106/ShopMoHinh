using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopMoHinh.AutoMapper
{
    public static class AutoMapperConfiguration
    {
        public static void Config()
        {
            new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<DtoEntityCommonMapper>();
            });
        }
    }
}
