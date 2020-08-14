using AutoMapper;
using CA.Application.ViewModels;
using CA.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>().ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}
