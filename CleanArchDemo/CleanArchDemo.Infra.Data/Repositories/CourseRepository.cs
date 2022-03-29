using CleanArchDemo.Domain.Interfaces;
using CleanArchDemo.Domain.Models;
using System.Collections.Generic;
using CleanArchDemo.Infra.Data.Context;

namespace CleanArchDemo.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}