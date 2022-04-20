using API.Data;
using API.Data.DTOS;
using API.Models;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories;

public class StudentRepository : IStudentRepository
{
    private IMapper _mapper;
    private readonly StudentContext _context;
    public StudentRepository(IMapper mapper, StudentContext context)
    {
        this._mapper = mapper;
        this._context = context;
    }

    public async Task<List<StudentDTO>> GetStudentsAsync()
    {
        var students = await _context.students.ToListAsync();
        return _mapper.Map<List<StudentDTO>>(students);
    }

    public async Task<StudentDTO> GetStudentAsync(Guid id)
    {
        var student = await _context.students.FindAsync(id);
        return _mapper.Map<StudentDTO>(student);
    }

    public async Task<bool> NewStudentAsync(NewStudentDTO student)
    {
        try
        {
            await _context.students.AddAsync(_mapper.Map<Student>(student));
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public async Task<bool> UpdateStudentAsync(Guid id, NewStudentDTO student)
    {
        try
        {
            var currentStudent = await _context.students.FindAsync(id);
            if (currentStudent == null) return false;
            _context.Entry(currentStudent).CurrentValues.SetValues(student);
            await _context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }


    public async Task<bool> DeleteStudentAsync(Guid id)
    {
        try
        {
            var currentStudent = await _context.students.FindAsync(id);
            if (currentStudent == null) return false;
            _context.students.Remove(currentStudent);
            _context.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }
}