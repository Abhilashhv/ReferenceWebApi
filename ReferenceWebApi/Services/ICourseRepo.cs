using ReferenceWebApi.Models;

namespace ReferenceWebApi.Services
{
    public interface ICourseRepo
    {
        Task<IEnumerable<Course>> GetCoursesAsync();
        Task<Course> GetCourseByIdAsync(int id);
        Task<List<Course>> CreateCourseAsync(Course course);
    }
}
