using API.Data;
using API.Data.DTOS;
using API.Models;
using API.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentController : ControllerBase
{
    private readonly IStudentRepository _studrepo;
    public StudentController(IStudentRepository studrepo)
    {
        this._studrepo = studrepo;
    }

    [HttpGet]
    public async Task<List<StudentDTO>> GetStudentsAsync()
    {
        return await _studrepo.GetStudentsAsync();
    }

    [HttpGet("{id}")]
    public async Task<StudentDTO> GetStudentAsync(Guid id)
    {
        return await _studrepo.GetStudentAsync(id);
    }

    [HttpPost]
    public async Task<bool> AddStudentAsync(NewStudentDTO student)
    {
        return await _studrepo.NewStudentAsync(student);
    }

    [HttpPut("{id}")]
    public async Task<bool> ModifyStudentAsync(Guid id, NewStudentDTO student)
    {
        return await _studrepo.UpdateStudentAsync(id, student);
    }

    [HttpDelete("{id}")]
    public async Task<bool> RemoveStudentAsync(Guid id)
    {
        return await _studrepo.DeleteStudentAsync(id);
    }
}