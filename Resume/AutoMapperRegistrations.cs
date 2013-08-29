using AutoMapper;
using Resume.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Resume
{
    public static class AutoMapperRegistrations
    {

        public static void Initialize()
        {
            Mapper.CreateMap<Model.Resume, ResumeViewModel>();
        }
    }
}