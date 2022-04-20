using API.Data.DTOS;

namespace API.Repositories;

public interface IStudentRepository
{
    Task<bool> DeleteStudentAsync(Guid id);
    Task<StudentDTO> GetStudentAsync(Guid id);
    Task<List<StudentDTO>> GetStudentsAsync();
    Task<bool> NewStudentAsync(NewStudentDTO student);
    Task<bool> UpdateStudentAsync(Guid id, NewStudentDTO student);
}
