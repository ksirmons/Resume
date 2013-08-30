using AutoMapper;
using Resume.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume.Web
{
    public static class AutoMapperRegistrations
    {

        public static void Initialize()
        {
            Mapper.CreateMap<Model.Resume, ResumeViewModel>();
            Mapper.CreateMap<Model.Resume, ResumeIndexItemViewModel>();
        }
    }
}