using AutoMapper;
using CleanArchDemo.Application.ViewModels;
using CleanArchDemo.Domain.Commands;
using CleanArchDemo.Domain.Models;

namespace CleanArchDemo.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();
        }
    }
}