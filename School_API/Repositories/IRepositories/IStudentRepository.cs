using SharedModels;

namespace School_API.Repositories.IRepositories
{
    public interface IStudentRepository : IRepository<Student>
    {
        Task<Student> UpdateAsync(Student student);
    }
}
