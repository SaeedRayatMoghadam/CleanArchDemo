using AutoMapper;
using CleanArchDemo.Application.ViewModels;
using CleanArchDemo.Domain.Commands;

namespace CleanArchDemo.Application.AutoMapper
{
    public class ViewModelToDomainProfile : Profile
    {
        public ViewModelToDomainProfile()
        {
            CreateMap<CourseViewModel, CreateCourseCommand>()
                .ConstructUsing(c => new CreateCourseCommand(c.Name, c.Description, c.ImageUrl));
        }
    }
}