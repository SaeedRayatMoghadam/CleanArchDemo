using CleanArchDemo.Application.Interfaces;
using CleanArchDemo.Application.ViewModels;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchDemo.Domain.Commands;
using CleanArchDemo.Domain.Core.Bus;
using CleanArchDemo.Domain.Interfaces;

namespace CleanArchDemo.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _mapper;
        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _mapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            _bus.SendCommand(_mapper.Map<CreateCourseCommand>(courseViewModel));
        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCourses().ProjectTo<CourseViewModel>(_mapper.ConfigurationProvider);
        }
    }
}