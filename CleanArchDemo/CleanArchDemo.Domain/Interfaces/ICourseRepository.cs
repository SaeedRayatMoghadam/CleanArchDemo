using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CleanArchDemo.Domain.Models;

namespace CleanArchDemo.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCourses();
        void Add(Course course);
    }
}