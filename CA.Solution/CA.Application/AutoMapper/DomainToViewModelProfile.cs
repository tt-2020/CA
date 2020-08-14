using AutoMapper;
using CA.Application.ViewModels;
using CA.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}
