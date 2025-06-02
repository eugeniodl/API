using Microsoft.EntityFrameworkCore;
using School_API.Data;
using School_API.Repositories.IRepositories;
using SharedModels;

namespace School_API.Repositories
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        private readonly SchoolContext _context;

        public StudentRepository(SchoolContext context) : base(context)
        {
            _context = context;
        }
        public async Task<Student> UpdateAsync(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return student;
        }
    }
}
