using Microsoft.EntityFrameworkCore;
using ReferenceWebApi.Data;
using ReferenceWebApi.Models;

namespace ReferenceWebApi.Services
{
    public class CourseRepo : ICourseRepo
    {
        private readonly DataContext context;

        public CourseRepo(DataContext context)
        {
            this.context = context;
        }
        public async Task<List<Course>> CreateCourseAsync(Course course)
        {
            context.Courses.Add(course);
            await context.SaveChangesAsync();
            return context.Courses.ToList();
        }

        public async Task<Course> GetCourseByIdAsync(int id)
        {
            var result = await context.Courses.FindAsync(id);
            if (result == null) 
            {
                return null;
            }
            return result;
        }

        public async Task<IEnumerable<Course>> GetCoursesAsync()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
