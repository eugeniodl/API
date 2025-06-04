using SharedModels;

namespace School_API.Repositories.IRepositories
{
    public interface IAttendanceRepository : IRepository<Attendance>
    {
        Task<Attendance> UpdateAsync(Attendance attendance);
    }
}
